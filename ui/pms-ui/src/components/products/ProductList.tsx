import { Box, Button } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import Product from "../../model/Product";

type ProductListProps = {
  rows: Product[];
};

const ProductList = ({ rows }: ProductListProps) => {
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
      renderCell: () => (
        <Box>
          <Button>Edytuj</Button>
          <Button>Usun</Button>
        </Box>
      ),
    },
  ];
  return (
    <Box>
      <DataGrid
        rows={rows}
        columns={columns}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[]}
      ></DataGrid>
    </Box>
  );
};

export default ProductList;
