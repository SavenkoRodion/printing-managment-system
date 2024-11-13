import { useState } from "react";
import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./CreateAdminDialog.style";
import getAxiosClient from "../../utility/getAxiosClient";

type CreateAdminDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
};

const CreateAdminDialog = ({ isOpen, handleClose }: CreateAdminDialogProps) => {
  const [adminName, setAdminName] = useState("");
  const [adminEmail, setAdminEmail] = useState("");
  const [adminPassword, setAdminPassword] = useState("");

  const client = getAxiosClient();

  const createAdmin = () => {
    client
      .post<boolean>("admin/create", {
        AdminName: adminName,
        AdminEmail: adminEmail,
        Password: adminPassword,
      })
      .then(() => {
        window.location.reload();
      })
      .catch(() => {
        alert("Nie udało się stworzyć nowego administratora");
      });
  };

  return (
    <Dialog open={isOpen} onClose={handleClose} maxWidth="xs" fullWidth>
      <DialogTitle>Stwórz nowego administratora</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        <TextField
          size="small"
          label="Imię"
          sx={styles.dialogElement}
          value={adminName}
          onChange={(e) => setAdminName(e.target.value)}
        />
        <TextField
          size="small"
          label="Email"
          sx={styles.dialogElement}
          value={adminEmail}
          onChange={(e) => setAdminEmail(e.target.value)}
        />
        <TextField
          size="small"
          label="Hasło"
          sx={styles.dialogElement}
          type="password"
          value={adminPassword}
          onChange={(e) => setAdminPassword(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={createAdmin}
        >
          Stwórz
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateAdminDialog;
