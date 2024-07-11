import './App.css';

import { ChatProvider } from './context/ChatContext';
import Container from "./components/Container";

function App() {
  return (
    <ChatProvider>
      <div className="App">
        <h1>Chat App</h1>
        <Container />
      </div>
    </ChatProvider>
  );
}

export default App;
