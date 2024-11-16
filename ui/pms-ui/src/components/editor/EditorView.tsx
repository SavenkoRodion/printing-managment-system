import React, { useState } from "react";
import {
  Box,
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  IconButton,
} from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import DeleteIcon from "@mui/icons-material/Delete";
import EditIcon from "@mui/icons-material/Edit";
import AddIcon from "@mui/icons-material/Add";
import { Worker, Viewer } from "@react-pdf-viewer/core";
import { zoomPlugin } from "@react-pdf-viewer/zoom";
import "@react-pdf-viewer/core/lib/styles/index.css";
import "@react-pdf-viewer/zoom/lib/styles/index.css";

interface EditorViewProps {}

const EditorView: React.FC<EditorViewProps> = () => {
  const [productType, setProductType] = useState<string>("");
  const [name, setName] = useState<string>("");
  const [client, setClient] = useState<string>("");
  const [file, setFile] = useState<File | null>(null); //przechowujemy file po wyborze PDF lub null przed wyborem
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
      renderCell: () => <input type="checkbox" />,
    },
    { field: "type", headerName: "Typ", width: 120 },
    { field: "zIndex", headerName: "Z-Index", width: 90 },
    { field: "value", headerName: "Wartość", width: 140 },
    {
      field: "actions",
      headerName: "",
      flex: 2,
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
    if (files && files[0]) { //files czyli wartosć jest inna niż null/undefined, files [0] to plik na liście czyli informacja -
      // - że użytkownik wybrał przynajmniej jeden plik
      setFile(files[0]); //po wykonaniu warunków wybieramy plik i aktualizaujemy komponent 
    }
  };

  return (
    <Box display="flex" flexDirection="row" gap={4}>
      <Box width="50%" display="flex" flexDirection="column" gap={2}>
        <Box display="flex" gap={2}>
          <FormControl fullWidth sx={{ minWidth: 200 }}>
            <InputLabel id="select-label" sx={{ mb: 1 }}>
              Wybór
            </InputLabel>
            <Select
              labelId="select-label"
              value={productType}
              onChange={(e) => setProductType(e.target.value)}
              sx={{ marginTop: 1 }}
            >
              <MenuItem value="option1">Opcja 1</MenuItem>
              <MenuItem value="option2">Opcja 2</MenuItem>
            </Select>
          </FormControl>
          <FormControl fullWidth>
            <TextField
              label="Tekst"
              value={name}
              onChange={(e) => setName(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
        </Box>

        <FormControl fullWidth>
          <TextField
            label="Początkowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
          />
        </FormControl>

        <FormControl fullWidth>
          <TextField
            label="Końcowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
          />
        </FormControl>

        <FormControl fullWidth>
          <TextField
            label="Sklep"
            value={client}
            onChange={(e) => setClient(e.target.value)}
          />
        </FormControl>

        <FormControl fullWidth>
          <TextField
            label="Adres sklepu"
            value={client}
            onChange={(e) => setClient(e.target.value)}
          />
        </FormControl>

        <Box mt={2}>
          <Button variant="contained">Dodaj obrazek</Button>
        </Box>

        <Box display="flex" flexWrap="wrap" gap={2}>
          <Button variant="contained">Dodaj pole tekstowe</Button>
          <Button variant="contained">Zapisz konfigurację</Button>
          <Button variant="contained">Dodaj QRCode</Button>
          <Button variant="contained">TSPANS</Button>
          <Button variant="contained">Pobierz</Button>
          <Button variant="contained">Grupuj</Button>
          <Button variant="contained">Grupuj teksty</Button>
        </Box>

        <Box mt={2} sx={{ height: 400 }}>
          <DataGrid rows={rows} columns={columns} pagination={true} />
        </Box>
      </Box>

      <Box
        width="50%"
        display="flex"
        flexDirection="column"
        gap={2}
        alignItems="center"
      >
        <Button
          variant="contained"
          component="label"
          sx={{ mt: 1, maxWidth: "200px" }}
        >
          Wybierz plik PDF
          <input
            type="file"
            accept="application/pdf"
            hidden
            onChange={onFileChange}
          />
        </Button>

        {file && (
          <Box
            style={{
              height: "955px",
              width: "100%",
              overflow: "hidden",
              border: "2px solid #000000", //czarny - nie wiem dlaczego jak dam #black to mi po kilku importach wywala kolor
              borderRadius: "8px",
            }}
          >
            <Worker workerUrl="node_modules/pdfjs-dist/build/pdf.worker.min.js">
              <Box display="flex" justifyContent="space-between" p={2}>
                <ZoomOut />
                <Box>
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
        )}
      </Box>
    </Box>
  );
};

export default EditorView;
