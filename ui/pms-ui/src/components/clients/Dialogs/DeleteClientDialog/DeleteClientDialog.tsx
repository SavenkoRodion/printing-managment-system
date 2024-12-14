import { Button, Dialog, DialogActions, DialogTitle } from "@mui/material";
import Client from "../../../../model/Client";

type DeleteClientDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleDelete: (uuid: string) => void;
  client: Client;
};

const DeleteClientDialog = ({
  isOpen,
  handleClose,
  handleDelete,
  client,
}: DeleteClientDialogProps) => {
  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Napewno chcesz usunąć klienta "{client.name}"?</DialogTitle>
      <DialogActions sx={{ padding: "0 15px 10px" }}>
        <Button
          color={"error"}
          variant="contained"
          onClick={() => {
            handleDelete(client.uuid);
            handleClose();
          }}
          size={"small"}
        >
          Usuń
        </Button>
        <Button onClick={handleClose} size={"small"}>
          Cofnij
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default DeleteClientDialog;
