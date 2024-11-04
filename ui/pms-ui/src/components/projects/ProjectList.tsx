import { useState, useCallback } from "react";
import { Box, Button, Checkbox } from "@mui/material";
import InputLabel from "@mui/material/InputLabel";
import MenuItem from "@mui/material/MenuItem";
import FormControl from "@mui/material/FormControl";
import Select, { SelectChangeEvent } from "@mui/material/Select";
import {
  DataGrid,
  GridCellParams,
  GridColDef,
  GridRenderCellParams,
} from "@mui/x-data-grid";
import { initialData, ProjectData } from "./initialData_front";

const ProjectSelector = () => {
  const keys = Object.keys(initialData);
  const [currentProject, setCurrentProject] = useState<string>("");
  const [dataGridRows, setDataGridRows] = useState<ProjectData[]>([]);

  const handleChange = (event: SelectChangeEvent) => {
    const selectedProject = event.target.value as string;
    setCurrentProject(selectedProject);
    setDataGridRows(initialData[selectedProject] || []);
  };

  const columns: GridColDef[] = [
    {
      field: "nazwa",
      headerName: "Nazwa",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "nazwaProduktu",
      headerName: "Nazwa produktu",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "format",
      headerName: "Format",
      width: 100,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "liczbaStron",
      headerName: "Liczba stron",
      width: 100,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "aktywnyUpload",
      headerName: "Aktywny upload",
      width: 150,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridRenderCellParams) => (
        <RenderCheckBox {...params} />
      ),
    },
    {
      field: "czyEdytowalny",
      headerName: "Czy edytowalny",
      width: 150,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridRenderCellParams) => (
        <RenderCheckBox {...params} />
      ),
    },
    {
      field: "przezKogoStworzony",
      headerName: "Przez kogo stworzony",
      width: 170,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "ostatniaModyfikacja",
      headerName: "Ostatnia modyfikacja",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "actions",
      headerName: "Akcje",
      sortable: false,
      width: 250,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridCellParams) => (
        <Box display="flex" justifyContent="center" width="100%">
          <Button
            size="small"
            variant="contained"
            color="primary"
            onClick={() => handleEdit(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Edytuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="secondary"
            onClick={() => handleCopy(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Kopiuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="error"
            onClick={() => handleDelete(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Usuń
          </Button>
        </Box>
      ),
    },
  ];

  const handleEdit = useCallback((id: number) => {
    console.log(`Edit product with id: ${id}`);
  }, []);

  const handleCopy = useCallback((id: number) => {
    console.log(`Copy product with id: ${id}`);
  }, []);

  const handleDelete = useCallback((id: number) => {
    console.log(`Delete product with id: ${id}`);
  }, []);

  const handleCheckboxChange = (
    params: GridRenderCellParams,
    checked: boolean
  ) => {
    console.log(
      `Checkbox change for ${params.field} with id ${params.row.id}: ${checked}`
    );
  };

  const RenderCheckBox = (props: GridRenderCellParams) => (
    <Checkbox
      size="medium"
      checked={props.value}
      onChange={(e) => handleCheckboxChange(props, e.target.checked)}
      style={{ margin: "0 auto", display: "block" }}
    />
  );

  return (
    <Box sx={{ minWidth: 300, marginBottom: 5 }}>
      <FormControl sx={{ m: 1, minWidth: 300 }}>
        <InputLabel id="select-label">Projects</InputLabel>
        <Select
          labelId="select-label"
          id="project-select"
          value={currentProject}
          label="Project"
          onChange={handleChange}
        >
          {keys.map((key) => (
            <MenuItem key={key} value={key}>
              {key}
            </MenuItem>
          ))}
        </Select>
      </FormControl>
      <Box sx={{ height: 400, width: "100%" }}>
        <DataGrid rows={dataGridRows} columns={columns} checkboxSelection />
      </Box>
    </Box>
  );
};

export default ProjectSelector;
