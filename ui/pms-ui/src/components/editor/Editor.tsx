import React, { useState } from 'react';
import {
  Container,
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  ToggleButton,
  ToggleButtonGroup,
  Box,
  Grid,
  IconButton,
} from '@mui/material';
import { DataGrid, GridColDef } from '@mui/x-data-grid';
import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';
import AddIcon from '@mui/icons-material/Add';

const App = () => {
  const [view, setView] = useState<string>('info');
  const [client, setClient] = useState<string>('');
  const [name, setName] = useState<string>('');
  const [productType, setProductType] = useState<string>('');
  const [format, setFormat] = useState<string>('');
  const [width, setWidth] = useState<string>('');
  const [height, setHeight] = useState<string>('');
  const [pdfWidth, setPdfWidth] = useState<string>('');
  const [pdfHeight, setPdfHeight] = useState<string>('');

  const rows = [
    { id: 1, type: 'text', zIndex: 1, value: 'Cennik usług' },
    { id: 2, type: 'text', zIndex: 2, value: 'dla domu' },
  ];

  const columns: GridColDef[] = [
    {
      field: 'select',
      headerName: '',
      width: 50,
      renderCell: () => (
        <input type="checkbox" />
      ),
    },
    { field: 'type', headerName: 'Typ', width: 100 },
    { field: 'zIndex', headerName: 'Z-Index', width: 60 },
    { field: 'value', headerName: 'Wartość', width: 150 },
    {
      field: 'actions',
      headerName: '',
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

  const handleSave = () => {
    console.log('Zapisałeś');
  };

  const handleViewChange = (
    _event: React.MouseEvent<HTMLElement>,
    newView: string
  ) => {
    if (newView !== null) {
      setView(newView);
    }
  };

  return (
    <Container>
      <Box display="flex" justifyContent="center" mb={2}>
        <ToggleButtonGroup
          value={view}
          exclusive
          onChange={handleViewChange}
          aria-label="view selection"
        >
          <ToggleButton value="info" aria-label="info view">
            Info
          </ToggleButton>
          <ToggleButton value="editor" aria-label="editor view">
            Edytor
          </ToggleButton>
        </ToggleButtonGroup>
      </Box>

      {view === 'info' && (
        <Box>
          <FormControl fullWidth margin="normal">
            <TextField
              label="Klient"
              value={client}
              onChange={(whatever) => setClient(whatever.target.value)}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <TextField
              label="Nazwa"
              value={name}
              onChange={(whatever) => setName(whatever.target.value)}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="product-type-label">Rodzaj produktu</InputLabel>
            <Select
              labelId="product-type-label"
              value={productType}
              onChange={(whatever) => setProductType(whatever.target.value)}
            >
              <MenuItem value="broszura">Broszura</MenuItem>
              <MenuItem value="broszura16">Broszura 16 stron</MenuItem>
              <MenuItem value="broszura32">Broszura 32 stron</MenuItem>
            </Select>
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="format-label">Format</InputLabel>
            <Select
              labelId="format-label"
              value={format}
              onChange={(whatever) => setFormat(whatever.target.value)}
            >
              <MenuItem value="a4">A4</MenuItem>
              <MenuItem value="a3">A3</MenuItem>
            </Select>
          </FormControl>

          <FormControl fullWidth margin="normal">
            <TextField
              label="Szerokość"
              value={width}
              onChange={(whatever) => setWidth(whatever.target.value)}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <TextField
              label="Wysokość"
              value={height}
              onChange={(whatever) => setHeight(whatever.target.value)}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <TextField
              label="Szerokość PDF"
              value={pdfWidth}
              onChange={(whatever) => setPdfWidth(whatever.target.value)}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <TextField
              label="Wysokość PDF"
              value={pdfHeight}
              onChange={(whatever) => setPdfHeight(whatever.target.value)}
            />
          </FormControl>

          <Box mt={4}>
            <Button variant="contained" onClick={handleSave}>
              Zapisz
            </Button>
          </Box>
        </Box>
      )}

      {view === 'editor' && (
        <Grid container spacing={2}>
          <Grid item xs={6}>
            <Box>
              <Box display="flex" mb={2}>
                <FormControl fullWidth margin="normal" sx={{ mr: 1 }}>
                  <InputLabel id="select-label">Wybór</InputLabel>
                  <Select
                    labelId="select-label"
                    value={productType}
                    onChange={(whatever) => setProductType(whatever.target.value)}
                  >
                    <MenuItem value="option1">Opcja 1</MenuItem>
                    <MenuItem value="option2">Opcja 2</MenuItem>
                  </Select>
                </FormControl>
                <FormControl fullWidth margin="normal">
                  <TextField
                    label="Tekst"
                    value={name}
                    onChange={(whatever) => setName(whatever.target.value)}
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
                  onChange={(whatever) => setClient(whatever.target.value)}
                />
              </FormControl>

              <FormControl fullWidth margin="normal">
                <TextField
                  label="Adres sklepu"
                  value={client}
                  onChange={(whatever) => setClient(whatever.target.value)}
                />
              </FormControl>

              <Box mt={2}>
                <Button variant="contained">Dodaj obrazek</Button>
              </Box>

              <Grid container spacing={2} mt={2} mb={1}>
                <Grid item xs={3}>
                  <Button variant="contained" fullWidth>Dodaj pole tekstowe</Button>
                </Grid>
                <Grid item xs={3}>
                  <Button variant="contained" fullWidth>Zapisz konfigurację</Button>
                </Grid>
                <Grid item xs={3}>
                  <Button variant="contained" fullWidth>Dodaj QRCode</Button>
                </Grid>
                <Grid item xs={3}>
                  <Button variant="contained" fullWidth>TSPANS</Button>
                </Grid>
                <Grid item xs={4}>
                  <Button variant="contained" fullWidth>Pobierz</Button>
                </Grid>
                <Grid item xs={4}>
                  <Button variant="contained" fullWidth>Grupuj</Button>
                </Grid>
                <Grid item xs={4}>
                  <Button variant="contained" fullWidth>Grupuj teksty</Button>
                </Grid>
              </Grid>

              <Box mt={2}>
                <div style={{ height: 300, width: '110%' }}>
                  <DataGrid
                    rows={rows}
                    columns={columns}
                    pagination={true}
                  />
                </div>
              </Box>
            </Box>
          </Grid>

          <Grid item xs={6}>
            <Box mb={2} display="flex" justifyContent="space-between" alignItems="center">
              <FormControl margin="normal" sx={{ mr: 1, width: '30%' }}>
                <TextField
                  label="Coś 1"
                  value={name}
                  onChange={(whatever) => setName(whatever.target.value)}
                />
              </FormControl>
              <FormControl margin="normal" sx={{ mr: 1, width: '30%' }}>
                <TextField
                  label="Coś 2"
                  value={client}
                  onChange={(whatever) => setClient(whatever.target.value)}
                />
              </FormControl>
              <Button variant="contained" sx={{ mr: 1 }}>Pogrubienie</Button>
              <Button variant="contained">Wyjustowanie</Button>
            </Box>
            <Box>
              <TextField
                label="Edytor"
                multiline
                rows={20}
                fullWidth
                variant="outlined"
              />
            </Box>
          </Grid>
        </Grid>
      )}
    </Container>
  );
};

export default App;
