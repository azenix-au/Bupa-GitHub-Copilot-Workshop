import { useState, useEffect } from "react";
import TodoList from "./TodoList";
import axios from 'axios';



function Todo() {
    const [data, setData] = useState([]);
    const [maxId, setMaxId] = useState(0);

    useEffect(() => {
        fetchTodoData();
    }, []);

    const fetchTodoData = () => {
        axios.get('http://localhost:5144/todoitems')
        .then((response) => {
            setData(response.data);
            setMaxId(Math.max(...response.data.map(todo => todo.id)));
        });
    };

    const handleCreate = (name) => {
        console.log('handleCreate: ', name);
        const newTodo = {
            id: maxId + 1,
            name: name,
            completed: false
        };

        axios.post('http://localhost:5144/todoitems', newTodo)
        .then((response) => {
            setData([...data, newTodo]);
            setMaxId(maxId + 1);
        });
        
    };

    const handleUpdate = (item) => {
        console.log('handleUpdate: ', item);
        axios.put(`http://localhost:5144/todoitems/${item.id}`, item)
        .then((response) => {
            const updatedData = data.map(todo => {
                if (todo.id === item.id) {
                    return item;
                }
                return todo;
            });
            setData(updatedData);
        });
        
    };

    const handleDelete = (id) => {
        axios.delete(`http://localhost:5144/todoitems/${id}`)
        .then((response) => {
            const updatedData = data.filter(todo => todo.id !== id);
            setData(updatedData);
        });
        
    };
    
    return (
        <div className="container">
            <TodoList
                name={'Todo List'}
                data={data}
                onCreate={handleCreate} 
                onUpdate={handleUpdate}
                onDelete={handleDelete}
            />
        </div>
    )
}

export default Todo;