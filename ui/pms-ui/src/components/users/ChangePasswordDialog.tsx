import {
  Box,
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import getAxiosClient from "../../utility/getAxiosClient";
import { useState } from "react";
import { isStatusCodeSuccessfull } from "../../utility/util";

type ResetPasswordDialogProps = {
  isOpen: boolean;
  onClose: () => void;
  userEmail: string;
  userId: string;
};

const ResetPasswordDialog = ({
  isOpen,
  onClose,
  userEmail,
  userId,
}: ResetPasswordDialogProps) => {
  const client = getAxiosClient();

  const [newPassword, setNewPassword] = useState("");

  const handlePasswordChange = () => {
    client
      .put("admin/change-password", {
        UserId: userId,
        NewPassword: newPassword,
      })
      .then((res) => {
        if (!isStatusCodeSuccessfull(res.status)) {
          alert("Nie udało się zmienić hasła");
        }
        window.location.reload();
      });
  };

  return (
    <Dialog open={isOpen} onClose={onClose} maxWidth="xs" fullWidth>
      <DialogTitle>Wprowadź nowe hasło dla użytkownika {userEmail}</DialogTitle>
      <DialogContent>
        <Box
          sx={{
            padding: "8px 0",
            gap: "8px",
            display: "flex",
            flexDirection: "column",
          }}
        >
          <TextField
            size={"small"}
            label="Nowe hasło"
            fullWidth
            value={newPassword}
            onChange={(e) => setNewPassword(e.target.value)}
            type={"password"}
          />
          <Button
            variant={"contained"}
            fullWidth
            onClick={handlePasswordChange}
          >
            Zmień hasło
          </Button>
        </Box>
      </DialogContent>
    </Dialog>
  );
};

export default ResetPasswordDialog;
