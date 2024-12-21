import React, { useEffect, useState } from "react";
import {
  Box,
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  IconButton,
  Checkbox,
  Stack,
  Typography,
} from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import DeleteIcon from "@mui/icons-material/Delete";
import EditIcon from "@mui/icons-material/Edit";
import AddIcon from "@mui/icons-material/Add";
import { Worker, Viewer } from "@react-pdf-viewer/core";
import { zoomPlugin } from "@react-pdf-viewer/zoom";
import "@react-pdf-viewer/core/lib/styles/index.css";
import "@react-pdf-viewer/zoom/lib/styles/index.css";
import { styles } from "./Editor.style";
import getAxiosClient from "../../utility/getAxiosClient";
import { useErrorSnackbar } from "../../hooks/UseErrorSnackbar";
import { useParams } from "react-router-dom";
import { EditorParams } from "./Editor";

interface EditorViewProps {}

const EditorView: React.FC<EditorViewProps> = () => {
  const [projectType, setProjectType] = useState<string>("");
  const [name, setName] = useState<string>("");
  const [client, setClient] = useState<string>("");
  const [file, setFile] = useState<File | null>(null);
  const zoomPluginInstance = zoomPlugin();
  const { ZoomIn, ZoomOut, CurrentScale } = zoomPluginInstance;

  const rows = [
    { id: 1, type: "text", zIndex: 1, value: "Cennik usług" },
    { id: 2, type: "text", zIndex: 2, value: "dla domu" },
  ];

  const columns: GridColDef[] = [
    {
      field: "select",
      headerName: "",
      flex: 1,
      renderCell: () => <Checkbox />,
    },
    { field: "type", headerName: "Typ", flex: 1 },
    { field: "zIndex", headerName: "Z-Index", flex: 1 },
    { field: "value", headerName: "Wartość", flex: 1 },
    {
      field: "actions",
      headerName: "",
      flex: 1.5,
      renderCell: () => (
        <Box>
          <IconButton aria-label="edit">
            <EditIcon />
          </IconButton>
          <IconButton aria-label="delete">
            <DeleteIcon />
          </IconButton>
          <IconButton aria-label="add">
            <AddIcon />
          </IconButton>
        </Box>
      ),
    },
  ];

  const onFileChange = (event: React.ChangeEvent<HTMLInputElement>) => {
    const files = event.target.files;
    if (files && files[0]) {
      if (files[0].type !== "application/pdf") {
        showMessage("Dozwolone są tylko pliki PDF");
        return;
      }
      setFile(files[0]);
    }
  };

  const { showMessage } = useErrorSnackbar();

  const { projectId, type } = useParams<EditorParams>();

  const submitProjectFile = async () => {
    const client = getAxiosClient();
    const formData = new FormData();
    formData.append("File", file!);
    formData.append("TemplateOrProject", type === "template" ? "0" : "1");
    formData.append("TemplateOrProjectId", projectId!);
    client
      .post("ProjectFile", formData)
      .then(() => showMessage("Udało się zapisać plik", true));
  };

  useEffect(() => {
    const client = getAxiosClient();
    client
      .get("ProjectFile", {
        responseType: "blob",
        params: {
          id: projectId,
          templateOrProject: type === "template" ? 0 : 1,
        },
      })
      .then((response) => {
        setFile(response.data);
      });
  }, [projectId, type]);

  return (
    <Box sx={styles.container}>
      <Box sx={styles.leftPanel}>
        <Box sx={{ display: "flex", gap: 2 }}>
          <FormControl sx={styles.formControl}>
            <InputLabel id="select-label" sx={styles.inputLabel}>
              Wybór
            </InputLabel>
            <Select
              labelId="select-label"
              value={projectType}
              onChange={(e) => setProjectType(e.target.value)}
              sx={styles.textField}
            >
              <MenuItem value="option1">Opcja 1</MenuItem>
              <MenuItem value="option2">Opcja 2</MenuItem>
            </Select>
          </FormControl>
          <FormControl sx={styles.formControl}>
            <TextField
              label="Tekst"
              value={name}
              onChange={(e) => setName(e.target.value)}
              sx={styles.textField}
            />
          </FormControl>
        </Box>

        <FormControl sx={styles.formControl}>
          <TextField
            label="Początkowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
            sx={styles.textField}
          />
        </FormControl>

        <FormControl sx={styles.formControl}>
          <TextField
            label="Końcowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
            sx={styles.textField}
          />
        </FormControl>

        <FormControl sx={styles.formControl}>
          <TextField
            label="Sklep"
            value={client}
            onChange={(e) => setClient(e.target.value)}
            sx={styles.textField}
          />
        </FormControl>

        <FormControl sx={styles.formControl}>
          <TextField
            label="Adres sklepu"
            value={client}
            onChange={(e) => setClient(e.target.value)}
            sx={styles.textField}
          />
        </FormControl>

        <Box sx={styles.buttonContainer}>
          <Button variant="contained">Dodaj obrazek</Button>
        </Box>

        <Box sx={styles.buttonsWrap}>
          <Button variant="contained">Dodaj pole tekstowe</Button>
          <Button variant="contained">Zapisz konfigurację</Button>
          <Button variant="contained">Dodaj QRCode</Button>
          <Button variant="contained">TSPANS</Button>
          <Button variant="contained">Pobierz</Button>
          <Button variant="contained">Grupuj</Button>
          <Button variant="contained">Grupuj teksty</Button>
        </Box>

        <Box sx={styles.dataGridContainer}>
          <DataGrid rows={rows} columns={columns} pagination={true} />
        </Box>
      </Box>

      <Box sx={styles.rightPanel}>
        <Stack direction={"row"} gap="8px">
          <Button variant="contained" component="label" sx={styles.fileButton}>
            Wybierz plik PDF
            <input
              type="file"
              accept="application/pdf"
              hidden
              onChange={onFileChange}
            />
          </Button>
          <Button
            variant="contained"
            sx={styles.fileButton}
            onClick={submitProjectFile}
            disabled={!file}
          >
            Zapisz plik projektu
          </Button>
        </Stack>

        {file ? (
          <Box sx={styles.pdfContainer}>
            <Worker workerUrl="/node_modules/pdfjs-dist/build/pdf.worker.min.js">
              <Box sx={styles.zoomControls}>
                <ZoomOut />
                <Box sx={styles.zoomInfo}>
                  Zoom <CurrentScale />
                </Box>
                <ZoomIn />
              </Box>
              <Viewer
                fileUrl={URL.createObjectURL(file)}
                plugins={[zoomPluginInstance]}
              />
            </Worker>
          </Box>
        ) : (
          <Box sx={styles.emptyPdfcontainer}>
            <Typography>Projekt nie ma przypisanego pliku PDF</Typography>
          </Box>
        )}
      </Box>
    </Box>
  );
};

export default EditorView;
