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
      valueFormatter: (params) => {
        return new Date(params.value as string).toLocaleDateString();
      },
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
            size="small"
            variant="contained"
            color="primary"
            sx={styles.buttonMargin}
            onClick={() => {
              handleEditDialogOpen(params.row.id, params.row.name);
            }}
          >
            Edytuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="error"
            sx={styles.buttonMargin}
            onClick={() => {
              handleDeleteDialogOpen(params.row.id, params.row.name);
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
        initialState={{
          pagination: { paginationModel: { pageSize: 10 } },
        }}
        rows={rows}
        columns={columns}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[10, 25, 50]}
        sx={styles.borderNone}
      />
    </Box>
  );
};

export default ProductList;
