import { useEffect, useState } from "react";
import {
  FormControl,
  TextField,
  Button,
  Select,
  MenuItem,
  InputLabel,
  Box,
  CircularProgress,
} from "@mui/material";
import getAxiosClient from "../../utility/getAxiosClient";
import Client from "../../model/Client";
import { useParams } from "react-router-dom";
import { EditorParams } from "./Editor";
import TemplateOrProject from "../../model/TemplateOrProject";
import { Controller, SubmitHandler, useForm } from "react-hook-form";
import Product from "../../model/Product";
import { isStatusCodeSuccessfull } from "../../utility/util";
import { useErrorSnackbar } from "../../hooks/UseErrorSnackbar";

const InfoView = () => {
  const { projectId, type } = useParams<EditorParams>();

  const [clientList, setClientList] = useState<Client[]>([]);
  const [productList, setProductList] = useState<Product[]>([]);
  const [isLoading, setIsLoading] = useState<boolean>(false);

  const { showError } = useErrorSnackbar();

  useEffect(() => {
    const axiosClient = getAxiosClient();

    axiosClient
      .get<Client[]>("client")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setClientList(e.data);
        } else {
          console.error("Błąd przy pobraniu listy użytkowników");
        }
      })
      .catch(() => showError("Błąd przy pobraniu listy użytkowników"));

    axiosClient
      .get<Product[]>("product")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setProductList(e.data);
        } else {
          showError("Błąd przy pobraniu listy produktów");
        }
      })
      .catch(() => showError("Błąd przy pobraniu listy produktów"));
  }, [showError]);

  const { handleSubmit, control, reset } = useForm<TemplateOrProject>();

  useEffect(() => {
    setIsLoading(true);

    const axiosClient = getAxiosClient();

    switch (type) {
      case "project":
        axiosClient
          .get<TemplateOrProject>(`project/${projectId}`)
          .then((e) => {
            if (isStatusCodeSuccessfull(e.status)) {
              reset(e.data);
              setIsLoading(false);
            } else {
              showError("Błąd przy pobraniu danych projektu");
            }
          })
          .catch(() => showError("Błąd przy pobraniu danych projektu"));
        break;
      case "template":
        axiosClient
          .get<TemplateOrProject>(`template/${projectId}`)
          .then((e) => {
            if (isStatusCodeSuccessfull(e.status)) {
              reset(e.data);
              setIsLoading(false);
            } else {
              showError("Błąd przy pobraniu danych szablonu");
            }
          })
          .catch(() => showError("Błąd przy pobraniu danych szablonu"));
        break;
    }
  }, [reset, projectId, type, showError]);

  const onSubmit: SubmitHandler<TemplateOrProject> = (data) => {
    const axiosClient = getAxiosClient();
    switch (type) {
      case "project":
        axiosClient
          .put("project/edit", {
            projectId: data.id,
            newProjectName: data.name,
            newClientId: data.clientId,
            newProductId: data.productId,
            newFormat: data.format,
          })
          .then(() => window.location.reload())
          .catch(() => showError("Nie udało się zedytować projekt"));

        break;
      case "template":
        axiosClient
          .put("template/edit", {
            templateId: data.id,
            newTemplateName: data.name,
            newClientId: data.clientId,
            newProductId: data.productId,
            newFormat: data.format,
          })
          .then(() => window.location.reload())
          .catch(() => showError("Nie udało się zedytować szablon"));
        break;
    }
  };

  return (
    <Box>
      {!isLoading ? (
        <form onSubmit={handleSubmit(onSubmit)}>
          <FormControl fullWidth margin="normal">
            <Controller
              control={control}
              name="name"
              render={({ field: { value, onChange } }) => (
                <TextField label="Nazwa" value={value} onChange={onChange} />
              )}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="demo-simple-select-label">Klient</InputLabel>
            <Controller
              control={control}
              name={"clientId"}
              render={({ field: { value, onChange } }) => {
                return (
                  <>
                    {value && clientList.length ? (
                      <Select
                        label="Klient"
                        labelId="demo-simple-select-label"
                        value={value}
                        onChange={onChange}
                      >
                        {clientList.map((e) => (
                          <MenuItem value={e.uuid} key={e.uuid}>
                            {e.name}
                          </MenuItem>
                        ))}
                      </Select>
                    ) : (
                      <></>
                    )}
                  </>
                );
              }}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <InputLabel id="product-type-label">Produkt</InputLabel>
            <Controller
              control={control}
              name={"productId"}
              render={({ field: { value, onChange } }) => {
                return (
                  <>
                    {value && productList.length ? (
                      <Select
                        labelId="product-type-label"
                        value={value}
                        onChange={onChange}
                        label={"Produkt"}
                      >
                        {productList.map((e) => (
                          <MenuItem value={e.id} key={e.id}>
                            {e.name}
                          </MenuItem>
                        ))}
                      </Select>
                    ) : (
                      <></>
                    )}
                  </>
                );
              }}
            />
          </FormControl>

          <FormControl fullWidth margin="normal">
            <Controller
              control={control}
              name="format"
              render={({ field: { value, onChange } }) => (
                <TextField label="Format" value={value} onChange={onChange} />
              )}
            />
          </FormControl>
          <Box mt={2}>
            <Button variant="contained" type="submit">
              Zapisz
            </Button>
          </Box>
        </form>
      ) : (
        <CircularProgress />
      )}
    </Box>
  );
};

export default InfoView;
