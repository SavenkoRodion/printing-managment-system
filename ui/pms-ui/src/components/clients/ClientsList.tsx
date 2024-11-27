import { Box, Button } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import Client from "../../model/Client";
import styles from "./Clients.style";

type ClientListProps = {
  rows: Client[];
  handleDeleteDialogOpen: (client: Client) => void;
  handleEditDialogOpen: (client: Client) => void;
};

const ClientList = ({
  rows,
  handleDeleteDialogOpen,
  handleEditDialogOpen,
}: ClientListProps) => {
  const columns: GridColDef[] = [
    {
      field: "name",
      headerName: "Nazwa klienta",
      align: "center",
      headerAlign: "center",
      flex: 1,
    },
    {
      field: "email",
      headerName: "Email",
      align: "center",
      headerAlign: "center",
      flex: 1,
    },
    {
      field: "address",
      headerName: "Adres",
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
      valueFormatter: (params) => {
        return new Date(params.value as string).toLocaleDateString();
      },
      disableReorder: true,
    },
    {
      field: "buttons",
      headerName: "Akcje",
      flex: 1,
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
            style={{ margin: "0 5px" }}
            onClick={() => {
              handleEditDialogOpen(params.row);
            }}
          >
            Edytuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="error"
            style={{ margin: "0 5px" }}
            onClick={() => {
              handleDeleteDialogOpen(params.row);
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
        getRowId={(row) => row.uuid}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[10]}
        sx={styles.borderNone}
      />
    </Box>
  );
};

export default ClientList;
