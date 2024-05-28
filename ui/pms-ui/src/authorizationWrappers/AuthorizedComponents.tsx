import AuthorizedExampleOne from "../components/authorized-example/AuthorizedExampleOne";
import AuthorizedExampleTwo from "../components/authorized-example/AuthorizedExampleTwo";
import AuthorizedComponent from "./AuthorizedComponent";

export const AuthorizedExampleOneWrapped = () => {
  return (
    <AuthorizedComponent>
      <AuthorizedExampleOne />
    </AuthorizedComponent>
  );
};
export const AuthorizedExampleTwoWrapped = () => {
  return (
    <AuthorizedComponent>
      <AuthorizedExampleTwo />
    </AuthorizedComponent>
  );
};
