import { Box } from "@mui/material";
import { DataGrid, GridColDef } from "@mui/x-data-grid";
import { useEffect, useState } from "react";

interface Parameter {
  id: number;
  name: string;
}

const Params = () => {
  const [parameters, setParameters] = useState<Parameter[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");

  useEffect(() => {
    const fetchParameters = async () => {
      try {
        const response = await fetch("https://localhost:7017/api/parameters");
        if (!response.ok) {
          throw new Error("Sieć odpowiedziała błędem.");
        }
        const data = await response.json();
        setParameters(data);
      } catch (err) {

        if (err instanceof Error) {
          setError(err.message);
        } else {
          setError("Wystąpił nieznany błąd.");
        }
      } finally {
        setLoading(false);
      }
    };
    
    fetchParameters();
  }, []);

  const columns: GridColDef[] = [
    {
      field: "id",
      headerName: "Id",
      align: "center",
      headerAlign: "center",
      flex: 0.15,
    },
    {
      field: "name",
      headerName: "Nazwa parametru",
      align: "center",
      headerAlign: "center",
      flex: 1,
    },
  ];

  if (loading) {
    return <div>Ładowanie danych</div>;
  }

  if (error) {
    return <div>Błąd {error}</div>;
  }

  return (
    <Box>
      <h1>Lista parametrów</h1>
      <DataGrid
        rows={parameters}
        columns={columns}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[]}
        autoHeight
      />
    </Box>
  );
};

export default Params;
