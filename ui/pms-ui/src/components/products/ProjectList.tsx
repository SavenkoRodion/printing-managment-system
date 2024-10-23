import { Box, Button, Checkbox } from "@mui/material";
import {
  DataGrid,
  GridCellParams,
  GridColDef,
  GridRenderCellParams,
} from "@mui/x-data-grid";
import { useState, useCallback } from "react";
import { useNavigate } from "react-router-dom";

const initialData = [
  {
    id: 1,
    nazwa: "Klient 1",
    nazwaProduktu: "Produkt 1",
    format: "A4",
    liczbaStron: 10,
    aktywnyUpload: true,
    czyEdytowalny: true,
    przezKogoStworzony: "Admin",
    ostatniaModyfikacja: "2024-10-16",
  },
  {
    id: 2,
    nazwa: "Klient 2",
    nazwaProduktu: "Produkt 2",
    format: "A3",
    liczbaStron: 5,
    aktywnyUpload: false,
    czyEdytowalny: false,
    przezKogoStworzony: "Użytkownik",
    ostatniaModyfikacja: "2024-10-16",
  },
];

const DisplayProducts = () => {
  const navigate = useNavigate();
  const [products, setProducts] = useState(initialData);
  const [error, setError] = useState<string | null>(null);
  const columns: GridColDef[] = [
    {
      field: "nazwa",
      headerName: "Nazwa",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "nazwaProduktu",
      headerName: "Nazwa produktu",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "format",
      headerName: "Format",
      width: 100,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "liczbaStron",
      headerName: "Liczba stron",
      width: 100,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "aktywnyUpload",
      headerName: "Aktywny upload",
      width: 150,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridRenderCellParams) => (
        <RenderCheckBox {...params} />
      ),
    },
    {
      field: "czyEdytowalny",
      headerName: "Czy edytowalny",
      width: 150,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridRenderCellParams) => (
        <RenderCheckBox {...params} />
      ),
    },
    {
      field: "przezKogoStworzony",
      headerName: "Przez kogo stworzony",
      width: 170,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "ostatniaModyfikacja",
      headerName: "Ostatnia modyfikacja",
      width: 150,
      align: "center",
      headerAlign: "center",
    },
    {
      field: "actions",
      headerName: "Akcje",
      sortable: false,
      width: 250,
      align: "center",
      headerAlign: "center",
      renderCell: (params: GridCellParams) => (
        <Box display="flex" justifyContent="center" width="100%">
          <Button
            size="small"
            variant="contained"
            color="primary"
            onClick={() => handleEdit(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Edytuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="secondary"
            onClick={() => handleCopy(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Kopiuj
          </Button>
          <Button
            size="small"
            variant="contained"
            color="error"
            onClick={() => handleDelete(params.row.id)}
            style={{ margin: "0 5px" }}
          >
            Usuń
          </Button>
        </Box>
      ),
    },
  ];

  const handleEdit = useCallback((id: any) => {
    console.log(`Edit product with id: ${id}`);
  }, []);
  const handleCopy = useCallback((id: any) => {
    console.log(`Copy product with id: ${id}`);
  }, []);
  const handleDelete = useCallback((id: any) => {
    console.log(`Delete product with id: ${id}`);
  }, []);

  const handleCheckboxChange = (
    params: GridRenderCellParams,
    checked: boolean
  ) => {
    const updatedProducts = products.map((product) => {
      if (product.id === params.id) {
        return { ...product, [params.field]: checked };
      }
      return product;
    });
    setProducts(updatedProducts);
  };

  const RenderCheckBox = (props: GridRenderCellParams) => {
    return (
      <Checkbox
        size="medium"
        checked={props.value}
        onChange={(e) => handleCheckboxChange(props, e.target.checked)}
        style={{ margin: "0 auto", display: "block" }}
      />
    );
  };

  // useEffect(() => {
  //   const fetchProducts = async () => {
  //     try {
  //       const response = await fetch("https://localhost:7017/api/produkty", {
  //         method: "GET",
  //         headers: {
  //           "Content-Type": "application/json",
  //         },
  //         credentials: "include",
  //       });
  //       if (!response.ok) {
  //         const errorText = await response.text();
  //         throw new Error(errorText);
  //       } else {
  //         const data = await response.json();
  //         setProducts(data);
  //       }
  //     } catch (error: unknown) {
  //       if (error instanceof Error) {
  //         setError(error.message);
  //       } else {
  //         setError("An unknown error occurred");
  //       }
  //     }
  //   };
  //   fetchProducts();
  // }, []);

  return (
    <Box style={{ height: 400, width: "100%" }}>
      {error && <div>Error: {error}</div>}
      <DataGrid
        rows={products}
        columns={columns}
        checkboxSelection
        autoHeight
      />
    </Box>
  );
};

export default DisplayProducts;
