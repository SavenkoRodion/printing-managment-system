import {
  Button,
  Dialog,
  DialogActions,
  DialogTitle,
  Alert,
} from "@mui/material";

type DeleteAdminDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleDelete: () => void;
  adminName: string;
  errorMessage?: string | null;
};

const DeleteAdminDialog = ({
  isOpen,
  handleClose,
  handleDelete,
  adminName,
  errorMessage,
}: DeleteAdminDialogProps) => {
  return (
    <Dialog open={isOpen} onClose={handleClose} maxWidth="xs" fullWidth>
      <DialogTitle>
        Czy na pewno chcesz usunąć administratora "{adminName}"?
      </DialogTitle>
      {errorMessage && (
        <Alert severity="error" sx={{ margin: "0 15px 10px" }}>
          {errorMessage}
        </Alert>
      )}
      <DialogActions sx={{ padding: "0 15px 10px" }}>
        <Button
          color="error"
          variant="contained"
          onClick={handleDelete}
          size="small"
        >
          Usuń
        </Button>
        <Button onClick={handleClose} size="small">
          Cofnij
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default DeleteAdminDialog;
