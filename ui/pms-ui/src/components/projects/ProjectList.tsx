import { useState, useCallback } from "react";
import {
  Box,
  Button,
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  SelectChangeEvent,
  Tabs,
  Tab,
} from "@mui/material";
import { DataGrid, GridColDef, GridCellParams } from "@mui/x-data-grid";
import { initialData, ProjectData } from "./initialData_front";
import RenderCheckBox from "./RenderCheckBox";
import { a11yProps } from "./utils";

const ProjectSelector = () => {
  const keys = Object.keys(initialData);
  const [currentProject, setCurrentProject] = useState<string>("");
  const [dataGridRows, setDataGridRows] = useState<ProjectData[]>([]);
  const [tabData, setTabData] = useState<{ [key: number]: ProjectData[] }>({
    0: [], // Data Szablony firmowe
    1: [], // Data Projekty zapisane
  });
  const [value, setValue] = useState(0);

  const handleChange = (event: SelectChangeEvent<string>) => {
    const selectedProject = event.target.value as string;
    setCurrentProject(selectedProject);

    setDataGridRows(initialData[selectedProject] || []);
  };

  const handleTabChange = (event: React.SyntheticEvent, newValue: number) => {
    setValue(newValue);
    setDataGridRows(tabData[newValue] || []);
  };

  const columns: GridColDef[] = [
    {
      field: "nazwa",
      headerName: "Nazwa",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "nazwaProduktu",
      headerName: "Nazwa produktu",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
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
      field: "czyEdytowalny",
      headerName: "Czy edytowalny",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      renderCell: RenderCheckBox,
    },
    {
      field: "przezKogoStworzony",
      headerName: "Przez kogo stworzony",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "ostatniaModyfikacja",
      headerName: "Ostatnia modyfikacja",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
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

  return (
    <Box>
      <Box sx={{ marginBottom: "20px" }}>
        <FormControl sx={{ minWidth: 300 }}>
          <InputLabel id="select-label">Klienci</InputLabel>
          <Select
            labelId="select-label"
            id="project-select"
            value={currentProject}
            label="Klienci"
            onChange={handleChange}
          >
            {keys.map((key) => (
              <MenuItem key={key} value={key}>
                {key}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
      </Box>
      <Box sx={{ marginBottom: "20px" }}>
        <Tabs
          value={value}
          onChange={handleTabChange}
          aria-label="basic tabs example"
        >
          <Tab label="Szablony firmowe" {...a11yProps(0)} />
          <Tab label="Projekty zapisane" {...a11yProps(1)} />
        </Tabs>
      </Box>

      <Box sx={{ height: 400, width: "100%" }}>
        <DataGrid rows={dataGridRows} columns={columns} checkboxSelection />
      </Box>
    </Box>
  );
};

export default ProjectSelector;
