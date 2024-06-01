import React from 'react';
import {
  Box,
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
} from '@mui/material';
import { DataGrid, GridColDef } from '@mui/x-data-grid';

interface EditorViewProps {
  productType: string;
  setProductType: React.Dispatch<React.SetStateAction<string>>;
  name: string;
  setName: React.Dispatch<React.SetStateAction<string>>;
  client: string;
  setClient: React.Dispatch<React.SetStateAction<string>>;
  rows: { id: number; type: string; zIndex: number; value: string }[];
  columns: GridColDef[];
}

const EditorView: React.FC<EditorViewProps> = ({
  productType,
  setProductType,
  name,
  setName,
  client,
  setClient,
  rows,
  columns,
}) => {
  return (
    <Box display="flex" flexDirection="row" flexWrap="nowrap" gap={2}>
      <Box flex="1 1 50%" display="flex" flexDirection="column" gap={2}>
        <Box display="flex" gap={2}>
          <FormControl fullWidth margin="normal" sx={{ minWidth: 200 }}>
            <InputLabel id="select-label" sx={{ mb:1 }}>Wybór</InputLabel>
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
          <FormControl fullWidth margin="normal">
            <TextField
              label="Tekst"
              value={name}
              onChange={(e) => setName(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
        </Box>

        <FormControl fullWidth margin="normal">
          <TextField
            label="Początkowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
          />
        </FormControl>

        <FormControl fullWidth margin="normal">
          <TextField
            label="Końcowa data oferty"
            type="date"
            InputLabelProps={{
              shrink: true,
            }}
          />
        </FormControl>

        <FormControl fullWidth margin="normal">
          <TextField
            label="Sklep"
            value={client}
            onChange={(e) => setClient(e.target.value)}
          />
        </FormControl>

        <FormControl fullWidth margin="normal">
          <TextField
            label="Adres sklepu"
            value={client}
            onChange={(e) => setClient(e.target.value)}
          />
        </FormControl>

        <Box mt={2}>
          <Button variant="contained">Dodaj obrazek</Button>
        </Box>

        <Box display="flex" flexWrap="wrap" gap={2} mt={2} mb={1}>
          <Button variant="contained" sx={{ flex: '25%' }}>Dodaj pole tekstowe</Button>
          <Button variant="contained" sx={{ flex: '25%' }}>Zapisz konfigurację</Button>
          <Button variant="contained" sx={{ flex: '25%' }}>Dodaj QRCode</Button>
          <Button variant="contained" sx={{ flex: '25%' }}>TSPANS</Button>
          <Button variant="contained" sx={{ flex: '33%' }}>Pobierz</Button>
          <Button variant="contained" sx={{ flex: '33%' }}>Grupuj</Button>
          <Button variant="contained" sx={{ flex: '33%' }}>Grupuj teksty</Button>
        </Box>

        <Box mt={2} sx={{ height: 300 }}>
          <DataGrid
            rows={rows}
            columns={columns}
            pagination={true}
          />
        </Box>
      </Box>

      <Box flex="1 1 50%" display="flex" flexDirection="column" gap={2}>
        <Box mb={2} display="flex" justifyContent="space-between" alignItems="center" gap={2}>
          <FormControl margin="normal" sx={{ flex: '1 1 auto' }}>
            <TextField
              label="Coś 1"
              value={name}
              onChange={(e) => setName(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
          <FormControl margin="normal" sx={{ flex: '1 1 auto' }}>
            <TextField
              label="Coś 2"
              value={client}
              onChange={(e) => setClient(e.target.value)}
              sx={{ marginTop: 1 }}
            />
          </FormControl>
          <Button variant="contained" color="primary" sx={{ marginTop: 1 }}>
            Rób
          </Button>
        </Box>
      </Box>
    </Box>
  );
};

export default EditorView;
