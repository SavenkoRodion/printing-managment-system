import {
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  Button,
} from "@mui/material";

interface DeleteDialogProps {
  isOpen: boolean;
  projectName: string;
  handleDelete: () => void;
  handleClose: () => void;
}

const DeleteDialog = ({
  isOpen,
  projectName,
  handleDelete,
  handleClose,
}: DeleteDialogProps) => (
  <Dialog
    open={isOpen}
    onClose={handleClose}
    maxWidth="xs"
    fullWidth
    closeAfterTransition={false}
  >
    <DialogTitle>Usuń {projectName}</DialogTitle>
    <DialogContent>Czy na pewno chcesz usunąć {projectName}?</DialogContent>
    <DialogActions>
      <Button
        onClick={handleClose}
        color={"primary"}
        variant="contained"
        size={"small"}
      >
        Anuluj
      </Button>
      <Button
        onClick={handleDelete}
        color={"error"}
        variant="contained"
        size={"small"}
      >
        Usuń
      </Button>
    </DialogActions>
  </Dialog>
);

export default DeleteDialog;
