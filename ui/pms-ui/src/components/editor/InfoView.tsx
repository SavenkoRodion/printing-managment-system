import { useState } from "react";
import {
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  Box,
} from "@mui/material";

const InfoView = () => {
  const [client, setClient] = useState<string>("");
  const [name, setName] = useState<string>("");
  const [productType, setProductType] = useState<string>("");
  const [format, setFormat] = useState<string>("");
  const [width, setWidth] = useState<string>("");
  const [height, setHeight] = useState<string>("");
  const [pdfWidth, setPdfWidth] = useState<string>("");
  const [pdfHeight, setPdfHeight] = useState<string>("");

  const handleSave = () => {
    console.log("Zapisałeś");
  };

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
        <InputLabel id="product-type-label" sx={{ marginBottom: 1 }}>
          Rodzaj produktu
        </InputLabel>
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
        <InputLabel id="format-label" sx={{ marginBottom: 1 }}>
          Format
        </InputLabel>
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
