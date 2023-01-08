import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { EducationDataFetch } from "./components/EducationDataFetch";
import { Home } from "./components/Home";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    },
    {
        path: '/education-fetch-data',
        element: <EducationDataFetch />
    }
];

export default AppRoutes;
