import { Box, Button, Typography } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import { useEffect, useState } from "react";
import getAxiosClient from "../../utility/getAxiosClient";
import Admin from "../../model/Admin";
import PageHeader from "../reusable/PageHeader";

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
    <Box>
      <PageHeader
        pageTitle="Lista użytkowników"
        handleCreate={() => {
          console.log("tmp");
        }}
        createButtonText="Nowy użytkownik"
      />
      <Box sx={{ paddingTop: "16px" }}>
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
            border: "none",
          }}
        />
      </Box>
    </Box>
  );
};

export default Users;
