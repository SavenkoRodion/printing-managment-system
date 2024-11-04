import { Box, Button, Typography } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import { useEffect, useState } from "react";
import getAxiosClient from "../../utility/getAxiosClient";
import Admin from "../../model/Admin";

const Users = () => {
  const [admins, setAdmins] = useState<Admin[]>([]);

  useEffect(() => {
    const client = getAxiosClient();
    client.get<Admin[]>("admin").then((response) => {
      setAdmins(response.data);
    });
  }, []);

  const columns: GridColDef[] = [
    {
      field: "email",
      headerName: "Email",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "createdAt",
      headerName: "Data utworzenia",
      flex: 0.5,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "actions",
      headerName: "Edycja",
      flex: 0.75,
      align: "center",
      headerAlign: "center",
      renderCell: () => (
        <Box sx={{ display: "flex", gap: 1 }}>
          <Button variant="outlined" size="small">
            Edytuj
          </Button>
          <Button variant="outlined" size="small">
            Uprawnienia
          </Button>
          <Button variant="outlined" size="small">
            Zmień hasło
          </Button>
          <Button variant="outlined" size="small" color="error">
            Usuń
          </Button>
        </Box>
      ),
    },
  ];

  return (
    <Box
      sx={{
        display: "flex",
        flexDirection: "column",
        alignItems: "stretch",
        gap: 2,
        padding: 2,
        border: "1px solid grey",
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
          borderBottom: "1px solid grey",
        }}
      >
        <Typography variant="h6">Lista użytkowników</Typography>
        <Button variant="contained" color="primary">
          Nowy użytkownik
        </Button>
      </Box>

      <DataGrid
        rows={admins}
        columns={columns}
        disableRowSelectionOnClick
        autoHeight
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[5, 10]}
        getRowId={(row) => row.uuid}
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
