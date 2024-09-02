import { Box } from "@mui/material";
import { DataGrid } from "@mui/x-data-grid";
import Product from "../../model/Product";

type ProductListProps = {
  rows: Product[];
};

const ProductList = ({ rows }: ProductListProps) => {
  return (
    <Box>
      <DataGrid rows={rows} columns={[]}></DataGrid>
    </Box>
  );
};

export default ProductList;
