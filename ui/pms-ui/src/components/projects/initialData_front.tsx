export interface ProjectData {
  id: number;
  nazwa: string;
  nazwaProduktu: string;
  format: string;
  liczbaStron: number;
  aktywnyUpload: boolean;
  czyEdytowalny: boolean;
  przezKogoStworzony: string;
  ostatniaModyfikacja: string;
}

export const initialData: { [key: string]: ProjectData[] } = {
  IKEA: [
    {
      id: 1,
      nazwa: "IKEA 1",
      nazwaProduktu: "IKEA 1",
      format: "A4",
      liczbaStron: 10,
      aktywnyUpload: true,
      czyEdytowalny: true,
      przezKogoStworzony: "Admin",
      ostatniaModyfikacja: "2024-10-16",
    },
    {
      id: 2,
      nazwa: "IKEA 2",
      nazwaProduktu: "IKEA 2",
      format: "A3",
      liczbaStron: 5,
      aktywnyUpload: false,
      czyEdytowalny: false,
      przezKogoStworzony: "Użytkownik",
      ostatniaModyfikacja: "2024-10-16",
    },
    {
      id: 3,
      nazwa: "IKEA 3",
      nazwaProduktu: "IKEA 3",
      format: "A5",
      liczbaStron: 12,
      aktywnyUpload: false,
      czyEdytowalny: false,
      przezKogoStworzony: "Użytkownik 3",
      ostatniaModyfikacja: "2024-10-16",
    },
  ],
  Castorama: [
    {
      id: 1,
      nazwa: "Castorama 1",
      nazwaProduktu: "Castorama 1",
      format: "A4",
      liczbaStron: 10,
      aktywnyUpload: false,
      czyEdytowalny: false,
      przezKogoStworzony: "tester",
      ostatniaModyfikacja: "2024-10-16",
    },
    {
      id: 2,
      nazwa: "Castorama 2",
      nazwaProduktu: "Castorama 2",
      format: "A3",
      liczbaStron: 5,
      aktywnyUpload: true,
      czyEdytowalny: true,
      przezKogoStworzony: "ABC",
      ostatniaModyfikacja: "2024-10-16",
    },
  ],
};
