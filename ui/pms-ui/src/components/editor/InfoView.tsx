import { useEffect, useState } from "react";
import {
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  Box,
  Stack,
} from "@mui/material";
import getAxiosClient from "../../utility/getAxiosClient";
import Client from "../../model/Client";
import { useParams } from "react-router-dom";

// type InfoViewProps = {

// }

const InfoView = () => {
  const axiosClient = getAxiosClient();

  const [client, setClient] = useState<Client | undefined>();
  const [clientList, setClientList] = useState<Client[]>([]);

  const { projectId } = useParams();

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

  useEffect(() => {
    axiosClient.get<Client[]>("client").then((e) => {
      setClientList(e.data);
    });
    axiosClient.get(`project/${projectId}`).then((e) => console.log(e));
  }, []);

  return (
    <Box>
      <Stack>
        <TextField
          label="Nazwa"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
      </Stack>

      <FormControl fullWidth margin="normal">
        <InputLabel id="demo-simple-select-label">Klient</InputLabel>
        <Select
          label="Klient"
          labelId="demo-simple-select-label"
          value={client?.uuid}
          onChange={(e) =>
            setClient(clientList.filter((z) => z.uuid === e.target.value)[0])
          }
        >
          {clientList.map((e) => (
            <MenuItem value={e.uuid}>{e.name}</MenuItem>
          ))}
        </Select>
      </FormControl>

      <FormControl fullWidth margin="normal">
        <InputLabel id="product-type-label">Produkt</InputLabel>
        <Select
          labelId="product-type-label"
          value={productType}
          onChange={(e) => setProductType(e.target.value)}
          label={"Produkt"}
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
          onChange={(e) => setFormat(e.target.value)}
          label="Format"
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
