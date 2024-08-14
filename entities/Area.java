package com.example.demo.entities;


import jakarta.persistence.*;
import jakarta.persistence.Table;

@Entity
@Table(name = "area")
public class Area {
    
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int aId;
    
    @Column(name = "aname", nullable = false)
    private String aname;
    
    @Column(name = "pincode")
    private String pincode;
    
    @ManyToOne
    @JoinColumn(name = "c_id")
    private City city;

    // Getters and Setters
}

