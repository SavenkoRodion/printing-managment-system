import { Box, Button, Typography } from "@mui/material";
import ProductList from "./ProductList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import Product from "../../model/Product";
import styles from "./Products.style";
import CreateProductModal from "./CreateProductDialog";

const ProductPage = () => {
  const [products, setProducts] = useState<Product[]>([]);
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);

  useEffect(() => {
    const client = getAxiosClient();
    client.get<Product[]>("product").then((e) => setProducts(e.data));
  }, []);

  return (
    <Box width={"100%"} padding={"10px 50px 0 50px"}>
      <Typography>Product Page</Typography>
      <ProductList rows={products} />
      <Button
        variant={"contained"}
        sx={styles.createButton}
        onClick={() => setIsCreateModalOpen(true)}
      >
        Dodaj nowy produkt
      </Button>
      <CreateProductModal
        isOpen={isCreateModalOpen}
        handleClose={() => setIsCreateModalOpen(false)}
      ></CreateProductModal>
    </Box>
  );
};

export default ProductPage;
