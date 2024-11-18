import {
  Dialog,
  DialogContent,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  FormControl,
  DialogTitle,
  Alert,
} from "@mui/material";
import styles from "./CreateDialog.style";
import { useEffect, useState } from "react";
import getAxiosClient from "../../../utility/getAxiosClient";
import { Client, Product } from "../../../utility/types";

type CreateModalProps = {
  isOpen: boolean;
  currentClient: string;
  currentTab: number;
  clients: Client[];
  handleClose: () => void;
  onCreate: (
    name: string,
    format: string,
    selectedClient: string,
    selectedProduct: number
  ) => void;
};

const CreateDialog = ({
  isOpen,
  currentClient,
  currentTab,
  clients,
  handleClose,
  onCreate,
}: CreateModalProps) => {
  const [error, setError] = useState<string | null>(null);
  const [name, setName] = useState("");
  const [format, setFormat] = useState("");
  const [selectedClient, setSelectedClient] = useState("");
  const [selectedProduct, setSelectedProduct] = useState<number>(0);
  const [products, setProducts] = useState<Product[]>([]);

  const client = getAxiosClient();

  useEffect(() => {
    client.get("/product").then((response) => {
      setProducts(response.data);
    });
  }, []);

  useEffect(() => {
    if (isOpen) {
      setSelectedClient(currentClient);
    }
  }, [isOpen, currentClient]);

  const handleCreate = () => {
    if (!name || !selectedClient || !selectedProduct || !format) {
      setError("Wszystkie pola muszą być wypełnione");
      setTimeout(() => setError(""), 3000);
      return;
    }

    onCreate(name, format, selectedClient, selectedProduct);
    handleDialogClose();
  };

  const handleDialogClose = () => {
    setName("");
    setFormat("");
    setSelectedClient("");
    setSelectedProduct(0);
    handleClose();
  };

  return (
    <Dialog open={isOpen} onClose={handleDialogClose} maxWidth="xs" fullWidth>
      {error && (
        <Alert
          severity="error"
          sx={{
            margin: 2,
            height: "44px",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
          }}
        >
          {error}
        </Alert>
      )}
      <DialogTitle>
        {currentTab === 0 ? "Stwórz nowy szablon" : "Stwórz nowy projekt"}
      </DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        <TextField
          size="small"
          label={currentTab === 0 ? "Nazwa szablonu" : "Nazwa projektu"}
          sx={styles.dialogElement}
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <FormControl size="small" sx={styles.dialogElement}>
          <InputLabel id="client-label">Client</InputLabel>
          <Select
            labelId="client-label"
            value={selectedClient}
            onChange={(e) => setSelectedClient(e.target.value)}
            label="Client"
          >
            {clients.map((client) => (
              <MenuItem key={client.uuid} value={client.uuid}>
                {client.name}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
        <FormControl size="small" sx={styles.dialogElement}>
          <InputLabel id="product-label">Product</InputLabel>
          <Select
            labelId="product-label"
            value={selectedProduct === 0 ? "" : selectedProduct}
            onChange={(e) => setSelectedProduct(Number(e.target.value))}
            label="Product"
          >
            {products.map((product) => (
              <MenuItem key={product.id} value={product.id}>
                {product.name}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
        <TextField
          size="small"
          label="Format"
          sx={styles.dialogElement}
          value={format}
          onChange={(e) => setFormat(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={handleCreate}
        >
          Stwórz
        </Button>
        <Button
          variant="contained"
          color="error"
          sx={styles.dialogElement}
          onClick={handleDialogClose}
        >
          Anuluj
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateDialog;
