import {
  Alert,
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./CreateClientDialog.style";
import { useState } from "react";
import getAxiosClient from "../../../../utility/getAxiosClient";
import { set } from "react-hook-form";

type CreateClientModalProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleCreate: () => void;
};

const CreateClientDialog = ({
  isOpen,
  handleClose,
  handleCreate,
}: CreateClientModalProps) => {
  const [clientName, setClientName] = useState("");
  const [clientEmail, setClientEmail] = useState("");
  const [clientAddress, setClientAddress] = useState("");
  const [errorMessage, setErrorMessage] = useState("");

  const client = getAxiosClient();

  const createClient = () => {
    setErrorMessage("");

    client
      .post("client/create", {
        ClientName: clientName,
        ClientEmail: clientEmail,
        ClientAddress: clientAddress,
      })
      .then(() => {
        setClientName("");
        setClientEmail("");
        setClientAddress("");

        handleCreate();
        handleClose();
      })
      .catch((error) => {
        if (error.response?.status === 409) {
          setErrorMessage("Użytkownik z tym adresem email już istnieje.");
        } else if (error.response?.status === 500) {
          setErrorMessage("Nie udało się stworzyć nowego clientistratora.");
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
      <DialogTitle>Stwórz nowego klienta</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        {errorMessage && (
          <Alert severity="error" sx={styles.dialogElement}>
            {errorMessage}
          </Alert>
        )}
        <TextField
          size="small"
          label="Nazwa klienta"
          sx={styles.dialogElement}
          value={clientName}
          onChange={(e) => setClientName(e.target.value)}
        />
        <TextField
          size="small"
          label="Email"
          sx={styles.dialogElement}
          value={clientEmail}
          onChange={(e) => setClientEmail(e.target.value)}
        />
        <TextField
          size="small"
          label="Adres"
          sx={styles.dialogElement}
          value={clientAddress}
          onChange={(e) => setClientAddress(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={createClient}
        >
          Stwórz
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateClientDialog;
