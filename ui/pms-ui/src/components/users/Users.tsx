import { Box, Button, Typography } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";

const rows = [
  { id: 1, email: "admin1@example.com", createdAt: "2023-05-12" },
  { id: 2, email: "admin2@example.com", createdAt: "2023-06-18" },
];

const columns: GridColDef[] = [
  { field: "id", headerName: "Id", flex: 0.15, align: "center", headerAlign: "center" },
  { field: "email", headerName: "Email", flex: 1, align: "center", headerAlign: "center" },
  { field: "createdAt", headerName: "Data utworzenia", flex: 0.5, align: "center", headerAlign: "center" },
  {
    field: "actions",
    headerName: "Edycja",
    flex: 1,
    align: "center",
    headerAlign: "center",
    renderCell: () => (
      <Box sx={{ display: "flex", gap: 1 }}>
        <Button variant="outlined" size="small">Edytuj</Button>
        <Button variant="outlined" size="small">Uprawnienia</Button>
        <Button variant="outlined" size="small">Zmień hasło</Button>
        <Button variant="outlined" size="small" color="error">Usuń</Button>
      </Box>
    ),
  },
];

const Users = () => {
  return (
    <Box
      sx={{
        display: "flex",
        flexDirection: "column",
        alignItems: "stretch",
        gap: 2,
        padding: 2,
        border: "1px solid #ddd",
        borderRadius: 1,
        boxShadow: 1,
      }}
    >
      <Box
        sx={{
          display: "flex",
          justifyContent: "space-between",
          alignItems: "center",
          paddingBottom: 2,
          borderBottom: "1px solid #ddd",
        }}
      >
        <Typography variant="h6" component="div">Użytkownicy systemowi</Typography>
        <Button variant="contained" color="primary">Nowy użytkownik</Button>
      </Box>

      <DataGrid
        rows={rows}
        columns={columns}
        disableRowSelectionOnClick
        autoHeight
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[5, 10]}
        sx={{
          width: "100%",
          marginTop: 2,
          border: "none",
        }}
      />
    </Box>
  );
};

export default Users;
