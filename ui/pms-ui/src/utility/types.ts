export type Client = {
  uuid: string;
  name: string;
};
export interface Admin {
  uuid: string;
  name: string;
}

export interface ProjectType {
  id: string;
  name: string;
  dateOfCreation: Date;
}

export interface Template {
  id?: number;
  name: string;
  clientId: string;
  client: Client;
  projectTypeId: number;
  format: string;
  liczbaStron: number;
  dateModified: Date;
  adminId: string;
  admin: Admin;
}

export interface Project {
  id?: number;
  name: string;
  clientId: string;
  client: Client;
  projectTypeId: number;
  format: string;
  liczbaStron: number;
  dateModified: Date;
  adminId: string;
  admin: Admin;
}
