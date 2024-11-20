import { useState, useCallback, useEffect } from "react";
import { Box, Alert } from "@mui/material";
import { Template, Project } from "../../utility/types";
import getAxiosClient from "../../utility/getAxiosClient";
import ClientSelector from "./ClientSelector";
import CustomTabs from "./CustomTabs";
import DataGridWithActions from "./DataGridWithActions";
import DeleteDialog from "./Dialogs/DeleteDialog";
import CustomTabPanel from "./CustomTabPanel";
import { useNavigate } from "react-router-dom";
import Client from "../../model/Client";
import { isStatusCodeSuccessfull, sortClientsByName } from "../../utility/util";
import AddProjectOrTemplate from "./AddProjectOrTemplate";

enum Tab {
  TemplateTab,
  ProjectTab,
}

const ProjectList = () => {
  const client = getAxiosClient();
  const [templates, setTemplates] = useState<Template[]>([]);
  const [projects, setProjects] = useState<Project[]>([]);
  const [clients, setClients] = useState<Client[]>([]);
  const [currentTab, setCurrentTab] = useState(Tab.TemplateTab);
  const [error, setError] = useState<string | null>(null);
  const [currentClient, setCurrentClient] = useState<string>("");
  const [dataTemplates, setDataTemplates] = useState<Template[]>([]);
  const [dataProjects, setDataProjects] = useState<Project[]>([]);
  const [isDeleteDialogOpen, setIsDeleteDialogOpen] = useState(false);
  const [deleteDialogProductName, setDeleteDialogProductName] =
    useState<string>("");
  const [deleteDialogProductId, setDeleteDialogProductId] = useState<
    number | undefined
  >(undefined);

  useEffect(() => {
    client
      .get("/template")
      .then((response) => setTemplates(response.data))
      .catch(console.error);
    client
      .get("/project")
      .then((response) => setProjects(response.data))
      .catch(console.error);
    client
      .get("/client")
      .then((response) => {
        setClients(sortClientsByName(response.data));
      })
      .catch(console.error);
  }, []);

  useEffect(() => {
    handleChangeClient(clients[0]?.uuid || "");
  }, [clients]);

  const handleChangeClient = (selectedClient: string) => {
    setCurrentClient(selectedClient);
    setDataTemplates(
      templates.filter((template) => template.clientId === selectedClient)
    );
    setDataProjects(
      projects.filter((project) => project.clientId === selectedClient)
    );
  };

  const handleTabChange = (newValue: Tab) => {
    setCurrentTab(newValue);
  };

  const handleDeleteDialogOpen = (productId: number, productName: string) => {
    setDeleteDialogProductId(productId);
    setDeleteDialogProductName(productName);
    setIsDeleteDialogOpen(true);
  };

  const navigate = useNavigate();
  const handleEdit = useCallback((id: number) => {
    console.log(`Edit template with id: ${id}`);
    navigate(`/edytor/${currentTab === 0 ? "template" : "project"}/${id}`);
  }, []);

  const handleDelete = useCallback(async () => {
    const itemId = deleteDialogProductId;
    if (itemId === undefined) return;

    const apiEndpoint =
      currentTab === Tab.TemplateTab
        ? `template/${itemId}`
        : `project/${itemId}`;
    const response = await client.delete<boolean>(apiEndpoint);
    if (isStatusCodeSuccessfull(response.status)) {
      const updatedItems =
        currentTab === Tab.TemplateTab ? templates : projects;
      const filteredItems = updatedItems.filter((item) => item.id !== itemId);
      currentTab === Tab.TemplateTab
        ? setTemplates(filteredItems)
        : setProjects(filteredItems);
      currentTab === Tab.TemplateTab
        ? setDataTemplates(
            filteredItems.filter((item) => item.clientId === currentClient)
          )
        : setDataProjects(
            filteredItems.filter((item) => item.clientId === currentClient)
          );
    } else {
      setError(
        currentTab === Tab.TemplateTab
          ? "Nie udało się usunąć szablonu"
          : "Nie udało się usunąć projektu"
      );
      setTimeout(() => setError(""), 5000);
    }
    setIsDeleteDialogOpen(false);
  }, [
    client,
    templates,
    projects,
    currentTab,
    currentClient,
    deleteDialogProductId,
  ]);

  const createTemplateOrProject = (
    name: string,
    format: string,
    selectedClient: string,
    selectedProduct: number
  ) => {
    client
      .post(`/${currentTab === Tab.TemplateTab ? "template" : "project"}`, {
        name: name,
        clientId: selectedClient,
        productId: selectedProduct,
        format: format,
      })
      .then((response) => {
        const newItem = response.data;

        if (currentTab === Tab.TemplateTab) {
          setTemplates([...templates, newItem]);
          if (selectedClient === currentClient) {
            setDataTemplates([...dataTemplates, newItem]);
          }
        } else {
          setProjects([...projects, newItem]);
          if (selectedClient === currentClient) {
            setDataProjects([...dataProjects, newItem]);
          }
        }

        setError("");
      })
      .catch((error) => {
        if (error.response) {
          setError(`Error: ${error.message}`);
        }
      });
  };

  return (
    <Box>
      <ClientSelector
        clients={clients}
        currentClient={currentClient}
        onClientChange={handleChangeClient}
      />
      <Box display="flex" justifyContent="space-between">
        <CustomTabs currentTab={currentTab} onTabChange={handleTabChange} />
        <AddProjectOrTemplate
          currentTab={currentTab}
          currentClient={currentClient}
          clients={clients}
          onCreate={createTemplateOrProject}
        />
      </Box>
      {error && <Alert severity="error">{error}</Alert>}
      <DeleteDialog
        isOpen={isDeleteDialogOpen}
        productName={deleteDialogProductName}
        handleDelete={handleDelete}
        handleClose={() => setIsDeleteDialogOpen(false)}
      />
      <CustomTabPanel value={currentTab} index={0}>
        <DataGridWithActions
          rows={dataTemplates}
          currentTab={currentTab}
          onDeleteDialogOpen={handleDeleteDialogOpen}
        />
      </CustomTabPanel>
      <CustomTabPanel value={currentTab} index={1}>
        <DataGridWithActions
          rows={dataProjects}
          currentTab={currentTab}
          onDeleteDialogOpen={handleDeleteDialogOpen}
        />
      </CustomTabPanel>
    </Box>
  );
};

export default ProjectList;
