import React from 'react';
import {
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  Box,
} from '@mui/material';

interface InfoViewProps {
  client: string;
  setClient: React.Dispatch<React.SetStateAction<string>>;
  name: string;
  setName: React.Dispatch<React.SetStateAction<string>>;
  productType: string;
  setProductType: React.Dispatch<React.SetStateAction<string>>;
  format: string;
  setFormat: React.Dispatch<React.SetStateAction<string>>;
  width: string;
  setWidth: React.Dispatch<React.SetStateAction<string>>;
  height: string;
  setHeight: React.Dispatch<React.SetStateAction<string>>;
  pdfWidth: string;
  setPdfWidth: React.Dispatch<React.SetStateAction<string>>;
  pdfHeight: string;
  setPdfHeight: React.Dispatch<React.SetStateAction<string>>;
  handleSave: () => void;
}

const InfoView: React.FC<InfoViewProps> = ({
  client,
  setClient,
  name,
  setName,
  productType,
  setProductType,
  format,
  setFormat,
  width,
  setWidth,
  height,
  setHeight,
  pdfWidth,
  setPdfWidth,
  pdfHeight,
  setPdfHeight,
  handleSave,
}) => {
  return (
    <Box>
      <FormControl fullWidth margin="normal">
        <TextField
          label="Klient"
          value={client}
          onChange={(e) => setClient(e.target.value)}
        />
      </FormControl>

      <FormControl fullWidth margin="normal">
        <TextField
          label="Nazwa"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
      </FormControl>

      <FormControl fullWidth margin="normal" sx={{ minWidth: 200 }}>
        <InputLabel id="product-type-label" sx={{ marginBottom: 1 }}>Rodzaj produktu</InputLabel>
        <Select
          labelId="product-type-label"
          value={productType}
          onChange={(e) => setProductType(e.target.value)}
          sx={{ marginTop: 1 }}
        >
          <MenuItem value="broszura">Broszura</MenuItem>
          <MenuItem value="broszura16">Broszura 16 stron</MenuItem>
          <MenuItem value="broszura32">Broszura 32 stron</MenuItem>
        </Select>
      </FormControl>

      <FormControl fullWidth margin="normal" sx={{ minWidth: 200 }}>
        <InputLabel id="format-label" sx={{ marginBottom: 1 }}>Format</InputLabel>
        <Select
          labelId="format-label"
          value={format}
          onChange={(e) => setFormat(e.target.value)}
          sx={{ marginTop: 1 }}
        >
          <MenuItem value="a4">A4</MenuItem>
          <MenuItem value="a3">A3</MenuItem>
        </Select>
      </FormControl>

      <FormControl fullWidth margin="normal">
        <TextField
          label="Szerokość"
          value={width}
          onChange={(e) => setWidth(e.target.value)}
        />
      </FormControl>

      <FormControl fullWidth margin="normal">
        <TextField
          label="Wysokość"
          value={height}
          onChange={(e) => setHeight(e.target.value)}
        />
      </FormControl>

      <FormControl fullWidth margin="normal">
        <TextField
          label="Szerokość PDF"
          value={pdfWidth}
          onChange={(e) => setPdfWidth(e.target.value)}
        />
      </FormControl>

      <FormControl fullWidth margin="normal">
        <TextField
          label="Wysokość PDF"
          value={pdfHeight}
          onChange={(e) => setPdfHeight(e.target.value)}
        />
      </FormControl>

      <Box mt={4}>
        <Button variant="contained" onClick={handleSave}>
          Zapisz
        </Button>
      </Box>
    </Box>
  );
};

export default InfoView;
