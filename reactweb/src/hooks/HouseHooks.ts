import { House } from "../types/house";
import Config from "../config";
import { useQuery } from "react-query";
import axios, { AxiosError } from "axios";

const useFetchHouses = () => {
    return useQuery<House[], AxiosError>("houses", () =>
    axios.get(`${Config.baseApiUrl}/houses`).then((resp) => resp.data)
    );
}

export default useFetchHouses;