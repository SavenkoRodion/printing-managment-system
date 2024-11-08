import { Box } from "@mui/material";
import ProductList from "./ProductList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import Product from "../../model/Product";
import CreateProductDialog from "./Dialogs/CreateProductDialog/CreateProductDialog";
import DeleteProductDialog from "./Dialogs/DeleteProductDialog/DeleteProductDialog";
import EditProductDialog from "./Dialogs/EditProductDialog/EditProductDialog";
import PageHeader from "../reusable/PageHeader";

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
      .put<boolean>("product/rename", {
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
    <Box>
      <PageHeader
        pageTitle="Lista produktów"
        handleCreate={() => setIsCreateModalOpen(true)}
        createButtonText="Dodaj nowy produkt"
      />
      <ProductList
        rows={products}
        handleDeleteDialogOpen={handleDeleteDialogOpen}
        handleEditDialogOpen={handleEditDialogOpen}
      />

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
