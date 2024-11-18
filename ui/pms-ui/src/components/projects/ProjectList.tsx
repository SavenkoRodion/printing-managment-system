import { useState, useCallback, useEffect } from "react";
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
import { Template, Admin, Project, Product } from "../../utility/types"; // Import types
import { a11yProps } from "./utils";
import getAxiosClient from "../../utility/getAxiosClient";
import CustomTabPanel from "./CustomTabPanel";
import { useNavigate } from "react-router-dom";
import Client from "../../model/Client";

const ProjectSelector = () => {
  const client = getAxiosClient();
  const [templates, setTemplates] = useState<Template[]>([]);
  const [projects, setProjects] = useState<Project[]>([]);
  const [clients, setClients] = useState<Client[]>([]);
  const [currentTab, setCurrentTab] = useState(0);
  const [currentClient, setCurrentClient] = useState<string>("");
  const [dataTemplates, setDataTemplates] = useState<Template[]>([]);
  const [dataProjects, setDataProjects] = useState<Project[]>([]);

  useEffect(() => {
    client
      .get("/template")
      .then((response) => setTemplates(response.data))
      .catch((error) => console.error("Error fetching templates:", error));
    client
      .get("/project")
      .then((response) => setProjects(response.data))
      .catch((error) => console.error("Error fetching projects:", error));

    client
      .get("/client")
      .then((response) => setClients(response.data))
      .catch((error) => console.error("Error fetching clients:", error));
  }, []);

  const handleChange = (event: SelectChangeEvent<string>) => {
    const selectedClient = event.target.value;
    setCurrentClient(selectedClient);
    const templatesForClient = templates.filter(
      (template) => template.clientId === selectedClient
    );
    const projectsForClient = projects.filter(
      (project) => project.clientId === selectedClient
    );
    setDataTemplates(templatesForClient);
    setDataProjects(projectsForClient);
  };
  const handleTabChange = (event: React.SyntheticEvent, newValue: number) => {
    setCurrentTab(newValue);
  };

  const columns: GridColDef[] = [
    {
      field: "name",
      headerName: "Nazwa",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "product",
      headerName: "Nazwa produktu",
      flex: 0.6,
      align: "center",
      headerAlign: "center",
      valueGetter: (params) => {
        const product = params.row.product as Product;
        return product.name ?? "";
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
        console.log(params);
        const product = params.row.author as Admin;
        return product.name ?? "";
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

  const navigate = useNavigate();
  const handleEdit = useCallback((id: number) => {
    console.log(`Edit template with id: ${id}`);
    navigate(`/edytor/${currentTab === 0 ? "template" : "project"}/${id}`);
  }, []);

  const handleCopy = useCallback((id: number) => {
    console.log(`Copy template with id: ${id}`);
  }, []);

  const handleDelete = useCallback((id: number) => {
    console.log(`Delete template with id: ${id}`);
  }, []);

  return (
    <Box>
      <Box sx={{ marginBottom: "20px" }}>
        <FormControl sx={{ minWidth: 300 }}>
          <InputLabel id="select-label">Klienci</InputLabel>
          <Select
            labelId="select-label"
            id="client-select"
            value={currentClient}
            label="Klienci"
            onChange={handleChange}
          >
            {clients.map((client) => (
              <MenuItem key={client.uuid} value={client.uuid}>
                {client.name}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
      </Box>
      <Box sx={{ marginBottom: "20px" }}>
        <Tabs
          value={currentTab}
          onChange={handleTabChange}
          aria-label="basic tabs example"
        >
          <Tab label="Szablony firmowe" {...a11yProps(0)} />
          <Tab label="Projekty zapisane" {...a11yProps(1)} />
        </Tabs>
      </Box>
      <CustomTabPanel value={currentTab} index={0}>
        <Box sx={{ height: 400, width: "100%" }}>
          <DataGrid rows={dataTemplates} columns={columns} checkboxSelection />
        </Box>
      </CustomTabPanel>
      <CustomTabPanel value={currentTab} index={1}>
        <Box sx={{ height: 400, width: "100%" }}>
          <DataGrid rows={dataProjects} columns={columns} checkboxSelection />
        </Box>
      </CustomTabPanel>
    </Box>
  );
};

export default ProjectSelector;
