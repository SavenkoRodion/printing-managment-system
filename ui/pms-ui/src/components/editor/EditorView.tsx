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

interface EditorViewProps {}

const EditorView: React.FC<EditorViewProps> = () => {
  const [productType, setProductType] = useState<string>("");
  const [name, setName] = useState<string>("");
  const [client, setClient] = useState<string>("");

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
    { field: "type", headerName: "Typ", width: 100 },
    { field: "zIndex", headerName: "Z-Index", width: 60 },
    { field: "value", headerName: "Wartość", width: 150 },
    {
      field: "actions",
      headerName: "",
      flex: 1,
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

  return (
    <Box display="flex" flexDirection="row" flexWrap="nowrap" gap={2}>
      <Box width="600px" display="flex" flexDirection="column" gap={2}>
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

        <Box mt={2} sx={{ height: 300 }}>
          <DataGrid rows={rows} columns={columns} pagination={true} />
        </Box>
      </Box>

      <Box width="600px" display="flex" flexDirection="column" gap={2}>
        <Box
          mb={2}
          display="flex"
          justifyContent="space-between"
          alignItems="center"
          gap={2}
        >
          <FormControl>
            <TextField
              label="Coś 1"
              value={name}
              onChange={(e) => setName(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
          <FormControl>
            <TextField
              label="Coś 2"
              value={client}
              onChange={(e) => setClient(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
          <Button variant="contained" color="primary">
            Mały przycisk
          </Button>
        </Box>
      </Box>
    </Box>
  );
};

export default EditorView;
