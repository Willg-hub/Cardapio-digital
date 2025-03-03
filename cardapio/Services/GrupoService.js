import axios from 'axios';

const API_URL = 'https://localhost:7056/Grupo';

export const getListaGrupo = async () => {
    try {
        const response = await axios.get(`${API_URL}/GetListaGrupo`);
        return response.data;
    } catch (error) {
        console.error("Erro ao buscar grupos:", error);
        return [];
    }
};