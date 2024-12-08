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

const InfoView = () => {
  const [clientList, setClientList] = useState<Client[]>([]);

  const { projectId, type } = useParams<EditorParams>();

  const [productList, setProductList] = useState<Product[]>([]);

  const [templateOrProject, setTemplateOrProject] =
    useState<TemplateOrProject>();

  useEffect(() => {
    const axiosClient = getAxiosClient();

    //TODO: Better error handling
    axiosClient
      .get<Client[]>("client")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setClientList(e.data);
        } else {
          console.error("Błąd przy pobraniu listy użytkowników");
        }
      })
      .catch(() => console.error("Błąd przy pobraniu listy użytkowników"));

    axiosClient
      .get<Product[]>("product")
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setProductList(e.data);
        } else {
          console.error("Błąd przy pobraniu listy produktów");
        }
      })
      .catch(() => console.error("Błąd przy pobraniu listy produktów"));
  }, []);

  const { handleSubmit, control, reset } = useForm<TemplateOrProject>({
    defaultValues: templateOrProject,
  });

  useEffect(() => {
    const axiosClient = getAxiosClient();

    axiosClient
      .get<TemplateOrProject>(`template/${projectId}`)
      .then((e) => {
        if (isStatusCodeSuccessfull(e.status)) {
          setTemplateOrProject(e.data);
          reset(e.data);
        } else {
          console.error("Błąd przy pobraniu danych szablonu/projektu");
        }
      })
      .catch(() =>
        console.error("Błąd przy pobraniu danych szablonu/projektu")
      );
  }, [reset, projectId]);

  const onSubmit: SubmitHandler<TemplateOrProject> = (data) => {
    const axiosClient = getAxiosClient();
    switch (type) {
      case "project":
        axiosClient.put("project/edit", {
          projectId: data.id,
          newProjectName: data.name,
          newClientId: data.clientId,
          newProductId: data.productId,
          newFormat: data.format,
        });
        window.location.reload();
        break;
      case "template":
        axiosClient.put("template/edit", {
          templateId: data.id,
          newTemplateName: data.name,
          newClientId: data.clientId,
          newProductId: data.productId,
          newFormat: data.format,
        });
        window.location.reload();
        break;
      default:
        console.error("lol");
    }
  };

  return (
    <Box>
      {productList.length && clientList.length && control ? (
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
