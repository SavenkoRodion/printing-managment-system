import {
  Button,
  Dialog,
  DialogContent,
  DialogTitle,
  TextField,
} from "@mui/material";
import styles from "./CreateProductDialog.style";
import { useState } from "react";
import getAxiosClient from "../../../../utility/getAxiosClient";

type CreateProductModalProps = {
  isOpen: boolean;
  handleClose: () => void;
};

const CreateProductDialog = ({
  isOpen,
  handleClose,
}: CreateProductModalProps) => {
  const [productName, setProductName] = useState("");

  const client = getAxiosClient();

  const createProduct = () => {
    client
      .post<boolean>("product", { ProductName: productName })
      .then(() => window.location.reload());
  };

  return (
    <Dialog
      open={isOpen}
      onClose={handleClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      <DialogTitle>Stwórz nowy produkt</DialogTitle>
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
          onClick={createProduct}
        >
          Stwórz
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateProductDialog;
