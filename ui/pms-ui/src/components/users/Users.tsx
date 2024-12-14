import { Box, Button } from "@mui/material";
import {
  DataGrid,
  gridClasses,
  GridColDef,
  GridRowParams,
} from "@mui/x-data-grid";
import { useEffect, useState } from "react";
import getAxiosClient from "../../utility/getAxiosClient";
import Admin from "../../model/Admin";
import PageHeader from "../reusable/PageHeader";
import ChangePasswordDialog from "./ChangePasswordDialog";
import ChangeNameDialog from "./ChangeNameDialog";
import CreateAdminDialog from "./CreateAdminDialog";
import DeleteAdminDialog from "./DeleteAdminDialog";
import { useErrorSnackbar } from "../../hooks/UseErrorSnackbar";

const Users = () => {
  const { showError } = useErrorSnackbar();
  const [admins, setAdmins] = useState<Admin[]>([]);
  const [isOpenChangePasswordDialog, setIsOpenChangePasswordDialog] =
    useState(false);
  const [changePasswordDialogUserEmail, setChangePasswordDialogUserEmail] =
    useState("");
  const [changePasswordDialogUserId, setChangePasswordDialogUserId] =
    useState("");
  const [isOpenChangeNameDialog, setIsOpenChangeNameDialog] = useState(false);
  const [changeNameDialogUserId, setChangeNameDialogUserId] = useState("");
  const [changeNameDialogUserEmail, setChangeNameDialogUserEmail] =
    useState("");
  const [changeNameDialogCurrentName, setChangeNameDialogCurrentName] =
    useState("");
  const [isCreateAdminDialogOpen, setCreateAdminDialogOpen] = useState(false);
  const [isOpenDeleteDialog, setIsOpenDeleteDialog] = useState(false);
  const [deleteAdminName, setDeleteAdminName] = useState("");
  const [deleteAdminId, setDeleteAdminId] = useState("");
  const [deleteDialogError, setDeleteDialogError] = useState<string | null>(
    null
  );
  const [loggedInUserEmail, setLoggedInUserEmail] = useState<string | null>(
    null
  );

  useEffect(() => {
    const client = getAxiosClient();
    client
      .get<Admin[]>("admin")
      .then((response) => {
        setAdmins(response.data);
      })
      .catch(() => {
        showError("Nie udało się pobrać listy administratorów.");
      });

    client
      .get("auth/who-am-i")
      .then((response) => {
        if (response.data && response.data.email) {
          setLoggedInUserEmail(response.data.email);
        }
      })
      .catch(() => {
        showError("Nie udało się pobrać informacji o zalogowanym użytkowniku.");
      });
  }, [showError]);

  const onChangePasswordDialogOpen = (userEmail: string, userId: string) => {
    setChangePasswordDialogUserId(userId);
    setChangePasswordDialogUserEmail(userEmail);
    setIsOpenChangePasswordDialog(true);
  };

  const onChangeNameDialogOpen = (
    userEmail: string,
    userId: string,
    currentName: string
  ) => {
    setChangeNameDialogUserId(userId);
    setChangeNameDialogUserEmail(userEmail);
    setChangeNameDialogCurrentName(currentName);
    setIsOpenChangeNameDialog(true);
  };

  const onDeleteDialogOpen = (adminId: string, adminName: string) => {
    setDeleteAdminId(adminId);
    setDeleteAdminName(adminName);
    setIsOpenDeleteDialog(true);
  };

  const handleDeleteAdmin = () => {
    const client = getAxiosClient();
    client
      .delete(`admin/${deleteAdminId}`)
      .then((response) => {
        if (response.status === 200 && response.data === false) {
          setDeleteDialogError(
            "Nie udało się usunąć administratora. Spróbuj ponownie."
          );
        } else {
          setAdmins((prevAdmins) =>
            prevAdmins.filter((admin) => admin.uuid !== deleteAdminId)
          );
          setIsOpenDeleteDialog(false);
          setDeleteDialogError(null);
        }
      })
      .catch((error) => {
        showError("Problem podczas usuwania administratora.");
        if (error.response) {
          if (error.response.status === 400) {
            setDeleteDialogError("Nie można usunąć siebie. Należy skierować prośbę do innego administratora.");
          } else {
            setDeleteDialogError(
              "Wystąpił błąd podczas usuwania administratora. Spróbuj ponownie."
            );
          }
        } else {
          setDeleteDialogError("Nie można połączyć się z serwerem.");
        }
      });
  };

  const columns: GridColDef[] = [
    {
      field: "email",
      headerName: "Email",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      valueFormatter: (params) => {
        if (params.value == loggedInUserEmail) {
          return params.value + " (Ty)";
        }
      },
    },
    {
      field: "name",
      headerName: "Imię",
      flex: 0.5,
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
      renderCell: (props) => (
        <Box sx={{ display: "flex", gap: 1 }}>
          <Button
            variant="contained"
            color="primary"
            size="small"
            onClick={() => {
              onChangeNameDialogOpen(
                props.row.email,
                props.row.uuid,
                props.row.name
              );
            }}
          >
            Edytuj
          </Button>
          <Button variant="contained" color="primary" size="small">
            Uprawnienia
          </Button>
          <Button
            variant="contained"
            color="primary"
            size="small"
            onClick={() => {
              onChangePasswordDialogOpen(props.row.email, props.row.uuid);
            }}
          >
            Zmień hasło
          </Button>
          {loggedInUserEmail && props.row.email !== loggedInUserEmail && (
            <Button
              variant="contained"
              size="small"
              color="error"
              onClick={() => onDeleteDialogOpen(props.row.uuid, props.row.name)}
            >
              Usuń
            </Button>
          )}
        </Box>
      ),
    },
  ];

  return (
    <Box>
      <PageHeader
        pageTitle="Lista użytkowników"
        handleCreate={() => setCreateAdminDialogOpen(true)}
        createButtonText="Nowy użytkownik"
      />
      <Box
        sx={{
          paddingTop: "16px",
          [`.${gridClasses.row}.highlighted-row`]: {
            backgroundColor: "#edf3fc",
            color: "#1a3e72",
          },
        }}
      >
        <DataGrid
          initialState={{
            pagination: { paginationModel: { pageSize: 10 } },
          }}
          getRowClassName={(params: GridRowParams) => {
            if (params.row.email === loggedInUserEmail) {
              return "highlighted-row";
            }
            return "";
          }}
          rows={admins}
          columns={columns}
          disableRowSelectionOnClick
          autoHeight
          checkboxSelection={false}
          disableColumnMenu
          pageSizeOptions={[10, 25, 50]}
          getRowId={(row) => row.uuid}
          sx={{
            border: "none",
          }}
        />
      </Box>
      <ChangePasswordDialog
        onClose={() => setIsOpenChangePasswordDialog(false)}
        isOpen={isOpenChangePasswordDialog}
        userEmail={changePasswordDialogUserEmail}
        userId={changePasswordDialogUserId}
      />
      <ChangeNameDialog
        onClose={() => setIsOpenChangeNameDialog(false)}
        isOpen={isOpenChangeNameDialog}
        userEmail={changeNameDialogUserEmail}
        userId={changeNameDialogUserId}
        currentName={changeNameDialogCurrentName}
      />
      <CreateAdminDialog
        isOpen={isCreateAdminDialogOpen}
        handleClose={() => setCreateAdminDialogOpen(false)}
      />
      <DeleteAdminDialog
        isOpen={isOpenDeleteDialog}
        handleClose={() => {
          setIsOpenDeleteDialog(false);
          setDeleteDialogError(null);
        }}
        handleDelete={handleDeleteAdmin}
        adminName={deleteAdminName}
        errorMessage={deleteDialogError}
      />
    </Box>
  );
};

export default Users;
