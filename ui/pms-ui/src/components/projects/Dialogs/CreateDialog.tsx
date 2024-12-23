import {
  Dialog,
  DialogContent,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  FormControl,
  DialogTitle,
  Alert,
} from "@mui/material";
import styles from "./CreateDialog.style";
import { useEffect, useState } from "react";
import getAxiosClient from "../../../utility/getAxiosClient";
import { Client, ProjectType } from "../../../utility/types";

enum Tab {
  TemplateTab,
  ProjectTab,
}

type CreateModalProps = {
  isOpen: boolean;
  currentClient: string;
  currentTab: Tab;
  clients: Client[];
  handleClose: () => void;
  onCreate: (
    name: string,
    format: string,
    selectedClient: string,
    selectedProjectType: number
  ) => void;
};

const CreateDialog = ({
  isOpen,
  currentClient,
  currentTab,
  clients,
  handleClose,
  onCreate,
}: CreateModalProps) => {
  const [error, setError] = useState<string | null>(null);
  const [name, setName] = useState("");
  const [format, setFormat] = useState("");
  const [selectedClient, setSelectedClient] = useState("");
  const [selectedProjectType, setSelectedProjectType] = useState<number>(0);
  const [projectTypes, setProjectTypes] = useState<ProjectType[]>([]);

  const client = getAxiosClient();

  useEffect(() => {
    client.get("/projectType").then((response) => {
      setProjectTypes(response.data);
      console.log(response.data);
    });
  }, []);

  useEffect(() => {
    if (isOpen) {
      setSelectedClient(currentClient);
    }
  }, [isOpen, currentClient]);

  const handleCreate = () => {
    if (!name || !selectedClient || !selectedProjectType || !format) {
      setError("Wszystkie pola muszą być wypełnione");
      setTimeout(() => setError(""), 3000);
      return;
    }

    onCreate(name, format, selectedClient, selectedProjectType);
    handleDialogClose();
  };

  const handleDialogClose = () => {
    setName("");
    setFormat("");
    setSelectedClient("");
    setSelectedProjectType(0);
    handleClose();
  };

  return (
    <Dialog
      open={isOpen}
      onClose={handleDialogClose}
      maxWidth="xs"
      fullWidth
      closeAfterTransition={false}
    >
      {error && (
        <Alert
          severity="error"
          sx={{
            margin: 2,
            height: "44px",
            display: "flex",
            alignItems: "center",
            justifyContent: "center",
          }}
        >
          {error}
        </Alert>
      )}
      <DialogTitle>
        {currentTab === Tab.TemplateTab
          ? "Stwórz nowy szablon"
          : "Stwórz nowy projekt"}
      </DialogTitle>
      <DialogContent sx={styles.dialogContent}>
        <TextField
          size="small"
          label={
            currentTab === Tab.TemplateTab ? "Nazwa szablonu" : "Nazwa projektu"
          }
          sx={styles.dialogElement}
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <FormControl size="small" sx={styles.dialogElement}>
          <InputLabel id="client-label">Klienci</InputLabel>
          <Select
            labelId="client-label"
            value={selectedClient}
            onChange={(e) => setSelectedClient(e.target.value)}
            label="Klienci"
          >
            {clients.map((client) => (
              <MenuItem key={client.uuid} value={client.uuid}>
                {client.name}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
        <FormControl size="small" sx={styles.dialogElement}>
          <InputLabel id="projectType-label">Rodzaj Projektu</InputLabel>
          <Select
            labelId="projectType-label"
            value={selectedProjectType === 0 ? "" : selectedProjectType}
            onChange={(e) => setSelectedProjectType(Number(e.target.value))}
            label="Rodzaj Projektu"
          >
            {projectTypes.map((projectType) => (
              <MenuItem key={projectType.id} value={projectType.id}>
                {projectType.name}
              </MenuItem>
            ))}
          </Select>
        </FormControl>
        <TextField
          size="small"
          label="Format"
          sx={styles.dialogElement}
          value={format}
          onChange={(e) => setFormat(e.target.value)}
        />
        <Button
          variant="contained"
          sx={styles.dialogElement}
          onClick={handleCreate}
        >
          Stwórz
        </Button>
        <Button
          variant="contained"
          color="error"
          sx={styles.dialogElement}
          onClick={handleDialogClose}
        >
          Anuluj
        </Button>
      </DialogContent>
    </Dialog>
  );
};

export default CreateDialog;
