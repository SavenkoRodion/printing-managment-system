import { Box } from "@mui/material";
import ProductList from "./ProductList";
import getAxiosClient from "../../utility/getAxiosClient";
import { useEffect, useState } from "react";
import Product from "../../model/Product";

const ProductPage = () => {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    const client = getAxiosClient();
    client.get<Product[]>("product").then((e) => setProducts(e.data));
  }, []);

  return (
    <Box>
      Product Page
      <>
        <ProductList rows={products} />
      </>
    </Box>
  );
};

export default ProductPage;
