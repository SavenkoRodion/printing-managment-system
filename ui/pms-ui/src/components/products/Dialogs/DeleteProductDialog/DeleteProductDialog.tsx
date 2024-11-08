import { Button, Dialog, DialogActions, DialogTitle } from "@mui/material";

type DeleteProductDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleDelete: () => void;
  productName: string;
};

const DeleteProductDialog = ({
  isOpen,
  handleClose,
  handleDelete,
  productName,
}: DeleteProductDialogProps) => {
  return (
    <Dialog open={isOpen} onClose={handleClose} maxWidth="xs">
      <DialogTitle>Napewno chcesz usunąć produkt "{productName}"?</DialogTitle>
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

export default DeleteProductDialog;
