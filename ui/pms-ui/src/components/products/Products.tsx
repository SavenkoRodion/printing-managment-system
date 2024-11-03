import { Box, Button } from "@mui/material";
import ProductList from "./ProductList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import Product from "../../model/Product";
import styles from "./Products.style";
import CreateProductDialog from "./Dialogs/CreateProductDialog/CreateProductDialog";
import DeleteProductDialog from "./Dialogs/DeleteProductDialog/DeleteProductDialog";
import EditProductDialog from "./Dialogs/EditProductDialog/EditProductDialog";

const ProductPage = () => {
  const client = getAxiosClient();

  const [products, setProducts] = useState<Product[]>([]);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);
  const [isDeleteDialogOpen, setIsDeleteDialogOpen] = useState(false);
  const [isEditDialogOpen, setIsEditDialogOpen] = useState(false);

  const [deleteDialogProductName, setDeleteDialogProductName] =
    useState<string>("");
  const [deleteDialogProductId, setDeleteDialogProductId] = useState<
    number | undefined
  >(undefined);

  const [editDialogProductId, setEditDialogProductId] = useState<
    number | undefined
  >(undefined);
  const [editDialogProductName, setEditDialogProductName] = useState("");

  const handleDeleteDialogOpen = (productId: number, productName: string) => {
    setDeleteDialogProductId(productId);
    setDeleteDialogProductName(productName);
    setIsDeleteDialogOpen(true);
  };

  const handleEditDialogOpen = (productId: number, productName: string) => {
    setEditDialogProductId(productId);
    setEditDialogProductName(productName);
    setIsEditDialogOpen(true);
  };

  const handleDelete = () => {
    client.delete<boolean>(`product/${deleteDialogProductId}`).then((res) => {
      res.data ? window.location.reload() : alert("fail");
    });
  };

  const handleUpdate = () => {
    client
      .put<boolean>("product", {
        Id: editDialogProductId,
        Name: editDialogProductName,
      })
      .then((res) => {
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
        handleEditDialogOpen={handleEditDialogOpen}
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
        productName={deleteDialogProductName}
        handleDelete={handleDelete}
      ></DeleteProductDialog>
      <EditProductDialog
        isOpen={isEditDialogOpen}
        handleClose={() => setIsEditDialogOpen(false)}
        handleEdit={handleUpdate}
        productName={editDialogProductName}
        setProductName={setEditDialogProductName}
      ></EditProductDialog>
    </Box>
  );
};

export default ProductPage;
