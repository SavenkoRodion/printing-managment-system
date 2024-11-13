import { Button, Dialog, DialogActions, DialogTitle } from "@mui/material";

type DeleteAdminDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleDelete: () => void;
  adminName: string;
};

const DeleteAdminDialog = ({
  isOpen,
  handleClose,
  handleDelete,
  adminName,
}: DeleteAdminDialogProps) => {
  return (
    <Dialog open={isOpen} onClose={handleClose} maxWidth="xs" fullWidth>
      <DialogTitle>Czy na pewno chcesz usunąć administratora "{adminName}"?</DialogTitle>
      <DialogActions sx={{ padding: "0 15px 10px" }}>
        <Button color="error" variant="contained" onClick={handleDelete} size="small">
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
