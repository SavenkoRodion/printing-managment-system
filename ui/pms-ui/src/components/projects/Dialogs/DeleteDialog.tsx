import {
  Dialog,
  DialogActions,
  DialogContent,
  DialogTitle,
  Button,
} from "@mui/material";

interface DeleteDialogProps {
  isOpen: boolean;
  productName: string;
  handleDelete: () => void;
  handleClose: () => void;
}

const DeleteDialog = ({
  isOpen,
  productName,
  handleDelete,
  handleClose,
}: DeleteDialogProps) => (
  <Dialog open={isOpen} onClose={handleClose} maxWidth="xs" fullWidth>
    <DialogTitle>Usuń {productName}</DialogTitle>
    <DialogContent>Czy na pewno chcesz usunąć {productName}?</DialogContent>
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
