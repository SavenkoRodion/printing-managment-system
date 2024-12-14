import { useState } from "react";
import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
  Alert,
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
  const [errorMessage, setErrorMessage] = useState("");

  const client = getAxiosClient();

  const createAdmin = () => {
    setErrorMessage("");
    client
      .post("admin/create", {
        AdminName: adminName,
        AdminEmail: adminEmail,
        Password: adminPassword,
      })
      .then(() => {
        window.location.reload();
      })
      .catch((error) => {
        if (error.response?.status === 409) {
          setErrorMessage("Użytkownik z tym adresem email już istnieje.");
        } else if (error.response?.status === 500) {
          setErrorMessage("Nie udało się stworzyć nowego administratora.");
        } else {
          setErrorMessage("Wystąpił nieznany błąd.");
        }
      });
  };

  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Stwórz nowego administratora</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        {errorMessage && (
          <Alert severity="error" sx={styles.dialogElement}>
            {errorMessage}
          </Alert>
        )}
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
