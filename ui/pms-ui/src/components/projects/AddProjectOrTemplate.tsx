import { Box, Button } from "@mui/material";
import CreateDialog from "../projects/Dialogs/CreateDialog";
import { useState } from "react";
import { Client } from "../../utility/types";

enum Tab {
  TemplateTab,
  ProjectTab,
}

interface AddProjectOrTemplateProps {
  currentTab: Tab;
  currentClient: string;
  clients: Client[];
  onCreate: (
    name: string,
    format: string,
    selectedClient: string,
    selectedProjectType: number
  ) => void;
}

const AddProjectOrTemplate = ({
  currentTab,
  currentClient,
  clients,
  onCreate,
}: AddProjectOrTemplateProps) => {
  const [isCreateModalOpen, setIsCreateModalOpen] = useState(false);

  return (
    <Box display="flex" justifyContent="flex-end">
      <Button
        size="small"
        variant="contained"
        color="primary"
        onClick={() => setIsCreateModalOpen(true)}
        style={{ margin: "0 25px 5px" }}
      >
        Add {currentTab === Tab.TemplateTab ? "Template" : "Project"}
      </Button>
      <CreateDialog
        isOpen={isCreateModalOpen}
        currentClient={currentClient}
        currentTab={currentTab}
        clients={clients}
        handleClose={() => setIsCreateModalOpen(false)}
        onCreate={onCreate}
      ></CreateDialog>
    </Box>
  );
};

export default AddProjectOrTemplate;
