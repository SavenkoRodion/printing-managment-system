import { Box, Button } from "@mui/material";
import { DataGrid, GridColDef, GridCellParams } from "@mui/x-data-grid";
import { ProjectType, Admin } from "../../utility/types";

interface DataGridWithActionsProps {
  rows: any[];
  onDeleteDialogOpen: (id: number, name: string) => void;
  onEdit: (id: number) => void;
}

const DataGridWithActions = ({
  rows,
  onDeleteDialogOpen,
  onEdit,
}: DataGridWithActionsProps): React.ReactElement => {
  const columns: GridColDef[] = [
    {
      field: "name",
      headerName: "Nazwa",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "projectType",
      headerName: "Rodzaj projektu",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      valueGetter: (params: GridCellParams) => {
        const projectType = params.row.projectType as ProjectType;
        return projectType.name ?? "";
      },
    },
    {
      field: "format",
      headerName: "Format",
      flex: 0.4,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "liczbaStron",
      headerName: "Liczba stron",
      flex: 0.4,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "admin",
      headerName: "Przez kogo stworzony",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      valueGetter: (params) => {
        const admin = params.row.author as Admin;
        return admin.name ?? "";
      },
    },
    {
      field: "dateModified",
      headerName: "Ostatnia modyfikacja",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridCellParams): React.ReactNode => (
        <Box display="flex" justifyContent="center" width="100%">
          {new Date(params.value as string).toLocaleDateString()}
        </Box>
      ),
    },
    {
      field: "actions",
      headerName: "Akcje",
      sortable: false,
      flex: 1,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridCellParams) => (
        <Box display="flex" justifyContent="center" width="100%">
          <Button
            size="small"
            variant="contained"
            color="primary"
            style={{ margin: "0 5px" }}
            onClick={() => onEdit(params.row.id)}
          >
            Edytuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="secondary"
            style={{ margin: "0 5px" }}
            onClick={() => console.log(`Copy ${params.row.id}`)}
          >
            Kopiuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="error"
            style={{ margin: "0 5px" }}
            onClick={() =>
              params.row.id &&
              params.row.name &&
              onDeleteDialogOpen(params.row.id, params.row.name)
            }
          >
            Usuń
          </Button>
        </Box>
      ),
    },
  ];

  return (
    <Box sx={{ width: "100%" }}>
      <DataGrid
        initialState={{
          pagination: { paginationModel: { pageSize: 10 } },
        }}
        rows={rows}
        columns={columns}
        scrollbarSize={0}
        rowSelection={false}
        checkboxSelection={false}
        pageSizeOptions={[10, 25, 50]}
        disableColumnMenu
        sx={{
          height: rows.length ? "auto" : 200,
        }}
      />
    </Box>
  );
};

export default DataGridWithActions;
