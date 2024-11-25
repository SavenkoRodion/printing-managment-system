import {
  FormControl,
  InputLabel,
  MenuItem,
  Select,
  SelectChangeEvent,
} from "@mui/material";
import { Client } from "../../utility/types";

interface ClientSelectorProps {
  clients: Client[];
  currentClient: string;
  onClientChange: (selectedClient: string) => void;
}

const ClientSelector = ({
  clients,
  currentClient,
  onClientChange,
}: ClientSelectorProps) => (
  <FormControl sx={{ minWidth: 300 }}>
    <InputLabel id="select-label">Klienci</InputLabel>
    <Select
      labelId="select-label"
      id="client-select"
      value={currentClient}
      label="Klienci"
      onChange={(event: SelectChangeEvent<string>) =>
        onClientChange(event.target.value)
      }
    >
      {clients.map((client) => (
        <MenuItem key={client.uuid} value={client.uuid}>
          {client.name}
        </MenuItem>
      ))}
    </Select>
  </FormControl>
);

export default ClientSelector;
