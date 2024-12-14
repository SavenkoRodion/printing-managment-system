import { Button, Dialog, DialogActions, DialogTitle } from "@mui/material";

type DeleteProjectTypeDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleDelete: () => void;
  projectTypeName: string;
};

const DeleteProjectTypeDialog = ({
  isOpen,
  handleClose,
  handleDelete,
  projectTypeName,
}: DeleteProjectTypeDialogProps) => {
  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>
        Napewno chcesz usunąć ten rodzaj projektu: "{projectTypeName}"?
      </DialogTitle>
      <DialogActions sx={{ padding: "0 15px 10px" }}>
        <Button
          color={"error"}
          variant="contained"
          onClick={handleDelete}
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

export default DeleteProjectTypeDialog;
