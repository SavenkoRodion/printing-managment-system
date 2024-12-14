import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./EditProductDialog.style";

type EditProductDialogProps = {
  isOpen: boolean;
  handleClose: () => void;
  handleEdit: () => void;
  productName: string;
  setProductName: (productName: string) => void;
};

const EditProductDialog = ({
  isOpen,
  handleClose,
  handleEdit,
  productName,
  setProductName,
}: EditProductDialogProps) => {
  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Edycja produktu</DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        <TextField
          size="small"
          label="Nazwa produktu"
          sx={styles.dialogElement}
          value={productName}
          onChange={(e) => setProductName(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={handleEdit}
        >
          Edytuj
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default EditProductDialog;
