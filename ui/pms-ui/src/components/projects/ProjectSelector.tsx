import { useState, useEffect, useCallback } from "react";
import { Box, Alert, Button } from "@mui/material";
import { Client, Template, Project, Admin } from "../../utility/types";
import { isStatusCodeSuccessfull } from "../../utility/util";
import getAxiosClient from "../../utility/getAxiosClient";
import ClientSelector from "./ClientSelector";
import CustomTabs from "./CustomTabs";
import DataGridWithActions from "./DataGridWithActions";
import DeleteDialog from "./Dialogs/DeleteDialog";
import CustomTabPanel from "./CustomTabPanel";
import AddProjectOrTemplate from "./AddProjectOrTemplate";

const ProjectSelector = () => {
  const client = getAxiosClient();
  const [templates, setTemplates] = useState<Template[]>([]);
  const [projects, setProjects] = useState<Project[]>([]);
  const [clients, setClients] = useState<Client[]>([]);
  const [currentTab, setCurrentTab] = useState(0);
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
      .then((response) => setClients(response.data))
      .catch(console.error);
  }, []);

  const handleChangeClient = (selectedClient: string) => {
    setCurrentClient(selectedClient);
    setDataTemplates(
      templates.filter((template) => template.clientId === selectedClient)
    );
    setDataProjects(
      projects.filter((project) => project.clientId === selectedClient)
    );
  };

  const handleTabChange = (newValue: number) => {
    setCurrentTab(newValue);
  };

  const handleDeleteDialogOpen = (productId: number, productName: string) => {
    setDeleteDialogProductId(productId);
    setDeleteDialogProductName(productName);
    setIsDeleteDialogOpen(true);
  };

  const handleDelete = useCallback(async () => {
    const itemId = deleteDialogProductId;
    if (itemId === undefined) return;

    const apiEndpoint =
      currentTab === 0 ? `template/${itemId}` : `project/${itemId}`;
    const response = await client.delete<boolean>(apiEndpoint);
    if (isStatusCodeSuccessfull(response.status)) {
      const updatedItems = currentTab === 0 ? templates : projects;
      const filteredItems = updatedItems.filter((item) => item.id !== itemId);
      currentTab === 0
        ? setTemplates(filteredItems)
        : setProjects(filteredItems);
      currentTab === 0
        ? setDataTemplates(
            filteredItems.filter((item) => item.clientId === currentClient)
          )
        : setDataProjects(
            filteredItems.filter((item) => item.clientId === currentClient)
          );
    } else {
      setError(
        currentTab === 0
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
    pageCount: number,
    selectedClient: string,
    selectedProduct: number,
    currentUserUuid: string
  ) => {
    console.log(
      name,
      format,
      pageCount,
      selectedClient,
      selectedProduct,
      currentUserUuid
    );

    client
      .post(`/${currentTab === 0 ? "template" : "project"}`, {
        name: name,
        clientId: selectedClient,
        productId: selectedProduct,
        format: format,
        liczbaStron: pageCount,
        adminId: currentUserUuid,
      })
      .then((response) => {
        console.log(response);
        console.log(response.data);
        const newItem = response.data;

        if (currentTab === 0) {
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
        // Check if the error is from the server (HTTP status 500)
        if (error.response) {
          const status = error.response.status;
          if (status === 500) {
            setError(
              "An error occurred while creating the item. Please try again."
            );
          } else if (status === 400) {
            setError(
              "Invalid data. Please check the information and try again."
            );
          } else {
            setError("An unknown error occurred. Please try again later.");
          }
        } else if (error.request) {
          // No response received from the server
          setError(
            "Server not responding. Please check your internet connection."
          );
        } else {
          // Error in setting up the request (e.g., network issue)
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
          onTabChange={handleTabChange}
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

export default ProjectSelector;
