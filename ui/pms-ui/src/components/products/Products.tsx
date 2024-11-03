import { Box, Button } from "@mui/material";
import ProductList from "./ProductList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import Product from "../../model/Product";
import styles from "./Products.style";
import CreateProductDialog from "./Dialogs/CreateProductDialog/CreateProductDialog";
import DeleteProductDialog from "./Dialogs/DeleteProductDialog/DeleteProductDialog";

const ProductPage = () => {
  const client = getAxiosClient();

  const [products, setProducts] = useState<Product[]>([]);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);
  const [isDeleteDialogOpen, setIsDeleteDialogOpen] = useState(false);
  const [dialogProductName, setDialogProductName] = useState<string>("");
  const [dialogProductId, setDialogProductId] = useState<number | undefined>(
    undefined
  );

  const handleDeleteDialogOpen = (productId: number, productName: string) => {
    setDialogProductId(productId);
    setDialogProductName(productName);
    setIsDeleteDialogOpen(true);
  };

  const handleDelete = () => {
    client.delete<boolean>(`product/${dialogProductId}`).then((res) => {
      res.data ? window.location.reload() : alert("fail");
    });
  };

  useEffect(() => {
    client.get<Product[]>("product").then((res) => setProducts(res.data));
  }, []);

  return (
    <Box width={"100%"} padding={"10px 50px 0 50px"}>
      <ProductList
        rows={products}
        handleDeleteDialogOpen={handleDeleteDialogOpen}
      />
      <Button
        variant={"contained"}
        sx={styles.createButton}
        onClick={() => setIsCreateModalOpen(true)}
      >
        Dodaj nowy produkt
      </Button>
      <CreateProductDialog
        isOpen={isCreateModalOpen}
        handleClose={() => setIsCreateModalOpen(false)}
      ></CreateProductDialog>
      <DeleteProductDialog
        isOpen={isDeleteDialogOpen}
        handleClose={() => setIsDeleteDialogOpen(false)}
        productName={dialogProductName}
        handleDelete={handleDelete}
      ></DeleteProductDialog>
    </Box>
  );
};

export default ProductPage;
