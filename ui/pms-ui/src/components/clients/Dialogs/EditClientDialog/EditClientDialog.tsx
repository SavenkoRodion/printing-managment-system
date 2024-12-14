import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./EditClientDialog.style";
import { useState, useEffect } from "react";
import Client from "../../../../model/Client";

type EditClientDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleEdit: (updatedClient: Client) => void;
  client: Client;
};

const EditClientDialog = ({
  isOpen,
  handleClose,
  handleEdit,
  client,
}: EditClientDialogProps) => {
  const [clientName, setClientName] = useState<string>(client?.name || "");
  const [clientEmail, setClientEmail] = useState<string>(client?.email || "");
  const [clientAddress, setClientAddress] = useState<string>(
    client?.address || ""
  );

  useEffect(() => {
    if (isOpen) {
      setClientName(client?.name || "");
      setClientEmail(client?.email || "");
      setClientAddress(client?.address || "");
    }
  }, [isOpen, client]);

  const handleSave = () => {
    const updatedClient = {
      ...client,
      name: clientName,
      email: clientEmail,
      address: clientAddress,
    };

    handleEdit(updatedClient);
    handleClose();
  };

  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Edycja klienta</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
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
          onClick={handleSave}
        >
          Edytuj
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default EditClientDialog;
