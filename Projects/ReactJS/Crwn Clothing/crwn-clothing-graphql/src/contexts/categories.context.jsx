import { createContext, useEffect, useState } from 'react';
import { useQuery, gql } from '@apollo/client';



export const CategoriesContext = createContext({
  categoriesMap: {},
});

const COLLECTIONS = gql`
  query {
    collections {
      id
      title
      items {
        id
        name
        price
        imageUrl
      }
    }
  }
`;

export const CategoriesProvider = ({ children }) => {
  const { loading, error, data } = useQuery(COLLECTIONS);
  const [categoriesMap, setCategoriesMap] = useState({});

  useEffect(() => {
    if (data) {
      const { collections } = data;
      const categories = collections.reduce((accumulator, collection) => {
        const { title, items } = collection;
        accumulator[title.toLowerCase()] = items;
        return accumulator;
      }, {});
      setCategoriesMap(categories);
    }
  }, [data]);

  const value = { categoriesMap, loading };
  return (
    <CategoriesContext.Provider value={value}>
      {children}
    </CategoriesContext.Provider>
  );
};
