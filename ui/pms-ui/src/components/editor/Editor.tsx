import React, { useState } from 'react';
import { Container, Box, ToggleButton, ToggleButtonGroup, IconButton } from '@mui/material';
import InfoView from './InfoView';
import EditorView from './EditorView';
import { View } from './views';
import { GridColDef } from '@mui/x-data-grid';
import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';
import AddIcon from '@mui/icons-material/Add';

const App = () => {
  const [view, setView] = useState<View>(View.Info);
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
      flex: 1,
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
    newView: View
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
          <ToggleButton value={View.Info} aria-label="info view">
            Info
          </ToggleButton>
          <ToggleButton value={View.Editor} aria-label="editor view">
            Edytor
          </ToggleButton>
        </ToggleButtonGroup>
      </Box>

      {view === View.Info && (
        <InfoView
          client={client}
          setClient={setClient}
          name={name}
          setName={setName}
          productType={productType}
          setProductType={setProductType}
          format={format}
          setFormat={setFormat}
          width={width}
          setWidth={setWidth}
          height={height}
          setHeight={setHeight}
          pdfWidth={pdfWidth}
          setPdfWidth={setPdfWidth}
          pdfHeight={pdfHeight}
          setPdfHeight={setPdfHeight}
          handleSave={handleSave}
        />
      )}

      {view === View.Editor && (
        <EditorView
          productType={productType}
          setProductType={setProductType}
          name={name}
          setName={setName}
          client={client}
          setClient={setClient}
          rows={rows}
          columns={columns}
        />
      )}
    </Container>
  );
};

export default App;
