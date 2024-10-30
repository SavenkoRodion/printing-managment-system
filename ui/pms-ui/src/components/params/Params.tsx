import { Box, Typography } from "@mui/material";
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
    <Box
      sx={{
        display: "flex",
        flexDirection: "column",
        alignItems: "stretch",
        gap: 2,
        padding: 2,
        border: "1px solid #ddd",
        borderRadius: 1,
        boxShadow: 1,
      }}
    >
      <Box
        sx={{
          paddingBottom: 2,
          borderBottom: "1px solid #ddd",
        }}
      >
        <Typography variant="h6" >Lista parametrów</Typography>
      </Box>
      <DataGrid
        rows={parameters}
        columns={columns}
        rowSelection={false}
        checkboxSelection={false}
        disableColumnMenu
        pageSizeOptions={[]}
        autoHeight
        sx={{
          border: "none",
        }}
      />
    </Box>
  );
};
export default Params;