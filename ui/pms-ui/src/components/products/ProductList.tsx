import { Box, Button } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import Product from "../../model/Product";
import styles from "./Products.style";

type ProductListProps = {
  rows: Product[];
  handleDeleteDialogOpen: (productId: number, productName: string) => void;
  handleEditDialogOpen: (productId: number, productName: string) => void;
};

const ProductList = ({
  rows,
  handleDeleteDialogOpen,
  handleEditDialogOpen,
}: ProductListProps) => {
  const columns: GridColDef[] = [
    {
      field: "id",
      headerName: "Id",
      align: "center",
      headerAlign: "center",
      flex: 0.15,
    },
    {
      field: "name",
      headerName: "Nazwa produktu",
      align: "center",
      headerAlign: "center",
      flex: 1,
    },
    {
      field: "dateOfCreation",
      headerName: "Data stworzenia",
      align: "center",
      headerAlign: "center",
      flex: 1,
      disableReorder: true,
    },
    {
      field: "buttons",
      headerName: "Akcje",
      flex: 0.3,
      align: "center",
      headerAlign: "center",
      disableColumnMenu: true,
      disableExport: true,
      disableReorder: true,
      renderCell: (params) => (
        <Box>
          <Button
            onClick={() => {
              const product = rows[(params.rowNode.id as number) - 1];
              handleEditDialogOpen(product.id, product.name);
            }}
          >
            Edytuj
          </Button>
          <Button
            onClick={() => {
              const product = rows[(params.rowNode.id as number) - 1];
              handleDeleteDialogOpen(product.id, product.name);
            }}
          >
            Usun
          </Button>
        </Box>
      ),
    },
  ];
  return (
    <Box sx={styles.tablePadding}>
      <DataGrid
        rows={rows}
        columns={columns}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[10]}
        sx={styles.borderNone}
      />
    </Box>
  );
};

export default ProductList;
